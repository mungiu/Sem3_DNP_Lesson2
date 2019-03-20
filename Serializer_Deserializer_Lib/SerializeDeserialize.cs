using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializeDeserializeLib
{
    public class SerializeDeserializeLib
    {
        /// USING BINARY FORMATTER
        ///
        IFormatter binaryFormatter = new BinaryFormatter();
        IFormatter soapFormatter = new SoapFormatter();
        XmlSerializer xmlSerializer;
        Stream writeStream;
        Stream readStream;

        public void SerializeBin(string fileName, object obj)
        {
            writeStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None);
            binaryFormatter.Serialize(writeStream, obj);
            writeStream.Close();
        }

        public object DeserializeBin(string fileName)
        {
            readStream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
            object obj = binaryFormatter.Deserialize(readStream);
            readStream.Close();
            return obj;
        }

        /// USING SOAP FORMATTER
        /// NOTE: SoapFormatter serializes the root object and all of its children
        /// 
        public void SerializeSoap(string fileName, object obj)
        {
            writeStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None);
            soapFormatter.Serialize(writeStream, obj);
            writeStream.Close();
        }

        public object DeserializeSoap(string fileName)
        {
            readStream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
            object obj = soapFormatter.Deserialize(readStream);
            readStream.Close();
            return obj;
        }

        /// USING XML SERIALIZER
        /// PROs: 
        /// * Generally speaking it offers much more flexibility in terms of what should be serialized and how it should be serialized.
        /// * If a property or field returns a complex object (such as an array or a class instance), 
        /// the XmlSerializer converts it to an element nested within the main XML document. 
        /// For example, the first class in the following code example returns an instance of the second class.
        /// 
        /// CONs:
        /// Can ONLY seialize objects that have a parameterless constructor.
        /// 
        public void SerializeXml(string fileName, object obj, Type type)
        {
            Type[] extraTypes = new Type[3];
            extraTypes[0] = typeof(string);
            extraTypes[1] = typeof(int);
            extraTypes[2] = typeof(double);

            xmlSerializer = new XmlSerializer(type, extraTypes);

            writeStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None);
            xmlSerializer.Serialize(writeStream, obj);
            writeStream.Close();
        }

        public object DeserializeXml(string fileName)
        {
            readStream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
            object obj = xmlSerializer.Deserialize(readStream);
            readStream.Close();
            return obj;
        }
    }
}
