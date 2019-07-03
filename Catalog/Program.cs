using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;

namespace Catalog
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                object lockToread = new object();

                List<Categories> lCategories;

                lock (lockToread)
                {
                    TextReader reader = new StreamReader("Categories.csv", Encoding.GetEncoding("iso-8859-1"));
                    var csvReader = new CsvReader(reader);
                    var categories = csvReader.GetRecords<Categories>();

                    lCategories = categories.ToList();
                }

                IEnumerable<Products> products;

                lock (lockToread)
                {
                    TextReader reader2 = new StreamReader("Products.csv", Encoding.GetEncoding("iso-8859-1"));
                    var csvReader2 = new CsvReader(reader2);
                    products = csvReader2.GetRecords<Products>();
                }                

                List<Category> listaCompleta = new List<Category>();
                var lista = products.ToList();
                foreach (var item in lCategories)
                {                    
                    var filtroLista = lista.FindAll(p => p.CategoryId == item.Id);
                    var resultado = Category.ContructorCategory(item, filtroLista);
                    listaCompleta.Add(resultado);
                }

                string JsonStr = null;

                MemoryStream str = new MemoryStream();

                DataContractJsonSerializer final = new DataContractJsonSerializer(listaCompleta.GetType());

                final.WriteObject(str, listaCompleta);

                str.Position = 0;
                StreamReader sr = new StreamReader(str);
                JsonStr = sr.ReadToEnd();

                var result = Encoding.UTF8.GetBytes(JsonStr);

                var serializer = new System.Xml.Serialization.XmlSerializer(typeof(List<Category>));

                TextWriter writer = new StreamWriter("Catalog.xml");
        
                serializer.Serialize(writer, listaCompleta);

                writer.Close();

                File.WriteAllBytes(Directory.GetCurrentDirectory() + "/Catalog.json", result);

                Console.WriteLine("Catalog.json ha sido guardado en: " + Directory.GetCurrentDirectory());
                Console.WriteLine("Catalog.xml ha sido guardado en: " + Directory.GetCurrentDirectory());
                Console.WriteLine("Pulse Enter para finalizar.");
                Console.ReadLine();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Console.ReadLine();
            }
        }
    }
}
