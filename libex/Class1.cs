using System.IO;

namespace libex
{
    public class sede
    {
        public static void Serialize<T>(T data, string filePath)
        {
            using (var writer = new StreamWriter(filePath))
            {
                var text = data.ToString();
                writer.Write(text);
            }
        }

        public static T Deserialize<T>(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            {
                var text = reader.ReadToEnd();
                return (T)Convert.ChangeType(text, typeof(T));
            }
        }
    }
}
