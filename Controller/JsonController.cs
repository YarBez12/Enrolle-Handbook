using EnrolleeHandbook.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Unicode;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnrolleeHandbook.Controller
{
    internal static class JsonController
    {
        internal static void SaveToJson(UniversitiesCollection itemCollection, string filePath)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            filePath = Path.Combine(currentDirectory, filePath);
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true, 
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
            };
             string jsonString = JsonSerializer.Serialize(itemCollection, options);
             File.WriteAllText(filePath, jsonString);
        }

        public static UniversitiesCollection LoadData(string filePath)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            filePath = Path.Combine(currentDirectory, filePath);
            if (File.Exists(filePath))
            {
                var jsonString = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<UniversitiesCollection>(jsonString);
            }
            return new UniversitiesCollection();
        }
    }
}
