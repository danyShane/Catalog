[assembly:System.Security.AllowPartiallyTrustedCallers()]
[assembly:System.Security.SecurityTransparent()]
[assembly:System.Security.SecurityRules(System.Security.SecurityRuleSet.Level1)]
[assembly:System.Xml.Serialization.XmlSerializerVersionAttribute(ParentAssemblyId=@"358eb96b-fbeb-48a3-9ab3-42729aec310f,", Version=@"1.0.0.0")]
namespace Microsoft.Xml.Serialization.GeneratedAssembly {

    public class XmlSerializationWriter1 : System.Xml.Serialization.XmlSerializationWriter {

        public void Write5_Categories(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"Categories", @"");
                return;
            }
            TopLevelElement();
            Write2_Categories(@"Categories", @"", ((global::Catalog.Categories)o), true, false);
        }

        public void Write6_Category(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"Category", @"");
                return;
            }
            TopLevelElement();
            Write4_Category(@"Category", @"", ((global::Catalog.Category)o), true, false);
        }

        public void Write7_Products(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"Products", @"");
                return;
            }
            TopLevelElement();
            Write3_Products(@"Products", @"", ((global::Catalog.Products)o), true, false);
        }

        void Write3_Products(string n, string ns, global::Catalog.Products o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::Catalog.Products)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"Products", @"");
            WriteElementStringRaw(@"Id", @"", System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)o.@Id)));
            WriteElementStringRaw(@"CategoryId", @"", System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)o.@CategoryId)));
            WriteElementString(@"Name", @"", ((global::System.String)o.@Name));
            WriteElementStringRaw(@"Price", @"", System.Xml.XmlConvert.ToString((global::System.Single)((global::System.Single)o.@Price)));
            WriteEndElement(o);
        }

        void Write4_Category(string n, string ns, global::Catalog.Category o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::Catalog.Category)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"Category", @"");
            WriteElementString(@"Description", @"", ((global::System.String)o.@Description));
            WriteElementStringRaw(@"Id", @"", System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)o.@Id)));
            WriteElementString(@"Name", @"", ((global::System.String)o.@Name));
            {
                global::System.Collections.Generic.List<global::Catalog.Products> a = (global::System.Collections.Generic.List<global::Catalog.Products>)((global::System.Collections.Generic.List<global::Catalog.Products>)o.@Products);
                if (a != null){
                    WriteStartElement(@"Products", @"", null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        Write3_Products(@"Products", @"", ((global::Catalog.Products)a[ia]), true, false);
                    }
                    WriteEndElement();
                }
            }
            WriteEndElement(o);
        }

        void Write2_Categories(string n, string ns, global::Catalog.Categories o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::Catalog.Categories)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"Categories", @"");
            WriteElementStringRaw(@"Id", @"", System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)o.@Id)));
            WriteElementString(@"Name", @"", ((global::System.String)o.@Name));
            WriteElementString(@"Description", @"", ((global::System.String)o.@Description));
            WriteEndElement(o);
        }

        protected override void InitCallbacks() {
        }
    }

    public class XmlSerializationReader1 : System.Xml.Serialization.XmlSerializationReader {

        public object Read5_Categories() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id1_Categories && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        o = Read2_Categories(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":Categories");
            }
            return (object)o;
        }

        public object Read6_Category() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id3_Category && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        o = Read4_Category(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":Category");
            }
            return (object)o;
        }

        public object Read7_Products() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id4_Products && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        o = Read3_Products(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":Products");
            }
            return (object)o;
        }

        global::Catalog.Products Read3_Products(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id4_Products && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::Catalog.Products o;
            o = new global::Catalog.Products();
            bool[] paramsRead = new bool[4];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations0 = 0;
            int readerCount0 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    do {
                        if (!paramsRead[0] && ((object) Reader.LocalName == (object)id5_Id && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            {
                                o.@Id = System.Xml.XmlConvert.ToInt32(Reader.ReadElementString());
                            }
                            paramsRead[0] = true;
                            break;
                        }
                        if (!paramsRead[1] && ((object) Reader.LocalName == (object)id6_CategoryId && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            {
                                o.@CategoryId = System.Xml.XmlConvert.ToInt32(Reader.ReadElementString());
                            }
                            paramsRead[1] = true;
                            break;
                        }
                        if (!paramsRead[2] && ((object) Reader.LocalName == (object)id7_Name && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            {
                                o.@Name = Reader.ReadElementString();
                            }
                            paramsRead[2] = true;
                            break;
                        }
                        if (!paramsRead[3] && ((object) Reader.LocalName == (object)id8_Price && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            {
                                o.@Price = System.Xml.XmlConvert.ToSingle(Reader.ReadElementString());
                            }
                            paramsRead[3] = true;
                            break;
                        }
                        UnknownNode((object)o, @":Id, :CategoryId, :Name, :Price");
                    } while (false);
                }
                else {
                    UnknownNode((object)o, @":Id, :CategoryId, :Name, :Price");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations0, ref readerCount0);
            }
            ReadEndElement();
            return o;
        }

        global::Catalog.Category Read4_Category(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id3_Category && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::Catalog.Category o;
            o = new global::Catalog.Category();
            if ((object)(o.@Products) == null) o.@Products = new global::System.Collections.Generic.List<global::Catalog.Products>();
            global::System.Collections.Generic.List<global::Catalog.Products> a_3 = (global::System.Collections.Generic.List<global::Catalog.Products>)o.@Products;
            bool[] paramsRead = new bool[4];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations1 = 0;
            int readerCount1 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    do {
                        if (!paramsRead[0] && ((object) Reader.LocalName == (object)id9_Description && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            {
                                o.@Description = Reader.ReadElementString();
                            }
                            paramsRead[0] = true;
                            break;
                        }
                        if (!paramsRead[1] && ((object) Reader.LocalName == (object)id5_Id && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            {
                                o.@Id = System.Xml.XmlConvert.ToInt32(Reader.ReadElementString());
                            }
                            paramsRead[1] = true;
                            break;
                        }
                        if (!paramsRead[2] && ((object) Reader.LocalName == (object)id7_Name && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            {
                                o.@Name = Reader.ReadElementString();
                            }
                            paramsRead[2] = true;
                            break;
                        }
                        if (((object) Reader.LocalName == (object)id4_Products && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            if (!ReadNull()) {
                                if ((object)(o.@Products) == null) o.@Products = new global::System.Collections.Generic.List<global::Catalog.Products>();
                                global::System.Collections.Generic.List<global::Catalog.Products> a_3_0 = (global::System.Collections.Generic.List<global::Catalog.Products>)o.@Products;
                                if ((Reader.IsEmptyElement)) {
                                    Reader.Skip();
                                }
                                else {
                                    Reader.ReadStartElement();
                                    Reader.MoveToContent();
                                    int whileIterations2 = 0;
                                    int readerCount2 = ReaderCount;
                                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                            do {
                                                if (((object) Reader.LocalName == (object)id4_Products && (object) Reader.NamespaceURI == (object)id2_Item)) {
                                                    if ((object)(a_3_0) == null) Reader.Skip(); else a_3_0.Add(Read3_Products(true, true));
                                                    break;
                                                }
                                                UnknownNode(null, @":Products");
                                            } while (false);
                                        }
                                        else {
                                            UnknownNode(null, @":Products");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations2, ref readerCount2);
                                    }
                                ReadEndElement();
                                }
                            }
                            break;
                        }
                        UnknownNode((object)o, @":Description, :Id, :Name, :Products");
                    } while (false);
                }
                else {
                    UnknownNode((object)o, @":Description, :Id, :Name, :Products");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations1, ref readerCount1);
            }
            ReadEndElement();
            return o;
        }

        global::Catalog.Categories Read2_Categories(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id1_Categories && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::Catalog.Categories o;
            o = new global::Catalog.Categories();
            bool[] paramsRead = new bool[3];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations3 = 0;
            int readerCount3 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    do {
                        if (!paramsRead[0] && ((object) Reader.LocalName == (object)id5_Id && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            {
                                o.@Id = System.Xml.XmlConvert.ToInt32(Reader.ReadElementString());
                            }
                            paramsRead[0] = true;
                            break;
                        }
                        if (!paramsRead[1] && ((object) Reader.LocalName == (object)id7_Name && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            {
                                o.@Name = Reader.ReadElementString();
                            }
                            paramsRead[1] = true;
                            break;
                        }
                        if (!paramsRead[2] && ((object) Reader.LocalName == (object)id9_Description && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            {
                                o.@Description = Reader.ReadElementString();
                            }
                            paramsRead[2] = true;
                            break;
                        }
                        UnknownNode((object)o, @":Id, :Name, :Description");
                    } while (false);
                }
                else {
                    UnknownNode((object)o, @":Id, :Name, :Description");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations3, ref readerCount3);
            }
            ReadEndElement();
            return o;
        }

        protected override void InitCallbacks() {
        }

        string id7_Name;
        string id2_Item;
        string id4_Products;
        string id9_Description;
        string id5_Id;
        string id8_Price;
        string id3_Category;
        string id1_Categories;
        string id6_CategoryId;

        protected override void InitIDs() {
            id7_Name = Reader.NameTable.Add(@"Name");
            id2_Item = Reader.NameTable.Add(@"");
            id4_Products = Reader.NameTable.Add(@"Products");
            id9_Description = Reader.NameTable.Add(@"Description");
            id5_Id = Reader.NameTable.Add(@"Id");
            id8_Price = Reader.NameTable.Add(@"Price");
            id3_Category = Reader.NameTable.Add(@"Category");
            id1_Categories = Reader.NameTable.Add(@"Categories");
            id6_CategoryId = Reader.NameTable.Add(@"CategoryId");
        }
    }

    public abstract class XmlSerializer1 : System.Xml.Serialization.XmlSerializer {
        protected override System.Xml.Serialization.XmlSerializationReader CreateReader() {
            return new XmlSerializationReader1();
        }
        protected override System.Xml.Serialization.XmlSerializationWriter CreateWriter() {
            return new XmlSerializationWriter1();
        }
    }

    public sealed class CategoriesSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"Categories", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write5_Categories(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read5_Categories();
        }
    }

    public sealed class CategorySerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"Category", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write6_Category(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read6_Category();
        }
    }

    public sealed class ProductsSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"Products", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write7_Products(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read7_Products();
        }
    }

    public class XmlSerializerContract : global::System.Xml.Serialization.XmlSerializerImplementation {
        public override global::System.Xml.Serialization.XmlSerializationReader Reader { get { return new XmlSerializationReader1(); } }
        public override global::System.Xml.Serialization.XmlSerializationWriter Writer { get { return new XmlSerializationWriter1(); } }
        System.Collections.Hashtable readMethods = null;
        public override System.Collections.Hashtable ReadMethods {
            get {
                if (readMethods == null) {
                    System.Collections.Hashtable _tmp = new System.Collections.Hashtable();
                    _tmp[@"Catalog.Categories::"] = @"Read5_Categories";
                    _tmp[@"Catalog.Category::"] = @"Read6_Category";
                    _tmp[@"Catalog.Products::"] = @"Read7_Products";
                    if (readMethods == null) readMethods = _tmp;
                }
                return readMethods;
            }
        }
        System.Collections.Hashtable writeMethods = null;
        public override System.Collections.Hashtable WriteMethods {
            get {
                if (writeMethods == null) {
                    System.Collections.Hashtable _tmp = new System.Collections.Hashtable();
                    _tmp[@"Catalog.Categories::"] = @"Write5_Categories";
                    _tmp[@"Catalog.Category::"] = @"Write6_Category";
                    _tmp[@"Catalog.Products::"] = @"Write7_Products";
                    if (writeMethods == null) writeMethods = _tmp;
                }
                return writeMethods;
            }
        }
        System.Collections.Hashtable typedSerializers = null;
        public override System.Collections.Hashtable TypedSerializers {
            get {
                if (typedSerializers == null) {
                    System.Collections.Hashtable _tmp = new System.Collections.Hashtable();
                    _tmp.Add(@"Catalog.Category::", new CategorySerializer());
                    _tmp.Add(@"Catalog.Categories::", new CategoriesSerializer());
                    _tmp.Add(@"Catalog.Products::", new ProductsSerializer());
                    if (typedSerializers == null) typedSerializers = _tmp;
                }
                return typedSerializers;
            }
        }
        public override System.Boolean CanSerialize(System.Type type) {
            if (type == typeof(global::Catalog.Categories)) return true;
            if (type == typeof(global::Catalog.Category)) return true;
            if (type == typeof(global::Catalog.Products)) return true;
            return false;
        }
        public override System.Xml.Serialization.XmlSerializer GetSerializer(System.Type type) {
            if (type == typeof(global::Catalog.Categories)) return new CategoriesSerializer();
            if (type == typeof(global::Catalog.Category)) return new CategorySerializer();
            if (type == typeof(global::Catalog.Products)) return new ProductsSerializer();
            return null;
        }
    }
}
