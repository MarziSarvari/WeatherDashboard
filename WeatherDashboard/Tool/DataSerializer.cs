using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml.Serialization;

namespace WeatherDashboard.Tool
{
    public static class DataSerializer
    {
        public static T Deserialize<T>(string file)
        {
            using (Stream s = File.Open(file, FileMode.Open))
            {
                XmlSerializer x = new XmlSerializer(typeof(T));
                return (T)x.Deserialize(s);
            }
        }

        public static void Serialize<T>(T data, string filePath)
        {
            using (var stream = File.Open(filePath, FileMode.Create))
            {
                var serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(stream, data);
            }
        }
    }
}
