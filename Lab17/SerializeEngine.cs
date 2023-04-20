using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lab17
{
    [Serializable]
    public class SerializeEngine
    {
        public float A { get; set; }
        public float B { get; set; }

        public SerializeEngine() : this(0.0f, 0.0f)
        {
            
        }

        public SerializeEngine(float a, float b)
        {
            A = a;
            B = b;
        }

        public void SerializeBinary(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, this);
            fs.Close();
        }

        public SerializeEngine DeserializeBinary(string filename)
        {
            // десеріалізуємо об'єкт з бінарного формату
            FileStream fs = new FileStream(filename, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            SerializeEngine rhombus = (SerializeEngine)formatter.Deserialize(fs);
            fs.Close();
            return rhombus;
        }

        public void SerializeXml(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(SerializeEngine));
            serializer.Serialize(fs, this);
            fs.Close();
        }

        public SerializeEngine DeserializeXml(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open);
            XmlSerializer serializer = new XmlSerializer(typeof(SerializeEngine));
            SerializeEngine rhombus = (SerializeEngine)serializer.Deserialize(fs);
            fs.Close();
            return rhombus;
        }
    }
}
