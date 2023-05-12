using TaskManagement.Common;
using TaskManagement.Database;
using TaskManagement.LanguageSystem;
using TaskManagement.Language.translator;
using System.Text;
using TaskManagement.Database.Models;
using System.Security.Cryptography;
using Newtonsoft.Json;
using System.Collections;
using TaskManagement.Database.DataJson;

namespace TaskManagement
{
    //Encapsulaiton
    public class Program
    {
        static void Main(string[] args)
        {
            DataOfJson.JsonDocFileToRam();

            Console.OutputEncoding = Encoding.UTF8; ////Dilleri desteklemek ucun
            Console.InputEncoding = Encoding.UTF8;   ////

            translateWords translateWords = new translateWords();
             
                translateWords.ShowMenu();
                translateWords.AddCommand();
                translateWords.LangChoise();                
        }
    }
}
