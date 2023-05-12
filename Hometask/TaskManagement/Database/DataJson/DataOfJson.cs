using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TaskManagement.Common;
using TaskManagement.Database.Models;

namespace TaskManagement.Database.DataJson
{
    public class DataOfJson
    {
        public static void JSonDocRamToFile()
        {
            var pathName = @"C:\DataOfCSharp\myFile.txt";           
            File.WriteAllText(pathName, System.Text.Json.JsonSerializer.Serialize(DataContext.Users));                  
        }
        public static void JsonDocFileToRam()
        {
            var pathName = @"C:\DataOfCSharp\myFile.txt";
            var readText = File.ReadAllText(pathName);
            var output = JsonConvert.DeserializeObject<List<User>>(readText);
            DataContext.Users = output!;
        }
    }
}
