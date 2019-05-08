using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace ListSerializer
{
    class ListSerializer
    {
        public static void SaveToList<T>(string path, List<T> objects)
        {
            using (var sw = new StreamWriter(path, false))
            {
                new XmlSerializer(typeof(List<T>)).Serialize(sw, objects);
            }
        }

        public static List<T> LoadFromList<T>(string path)
        {
            using (var sr = new StreamReader(path))
            {
                return (List<T>)new XmlSerializer(typeof(List<T>)).Deserialize(sr);
            }
        }
    }
}
