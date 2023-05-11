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
        public static void JSon(User human)
        {
            string pathName = @"C:\DataOfCSharp\myFile.txt";

            //File.WriteAllText(pathName, JsonSerializer.Serialize(human));
            File.WriteAllText(pathName, JsonSerializer.Serialize(DataContext.Users));
        }
    }
}
