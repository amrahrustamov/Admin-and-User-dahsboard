using TaskManagement.Common;
using TaskManagement.Database;
using TaskManagement.LanguageSystem;
using TaskManagement.Language.translator;
using System.Text;
using TaskManagement.Database.Models;
using System.Security.Cryptography;
using Newtonsoft.Json;
using System.Collections;

namespace TaskManagement
{
    //Encapsulaiton
    public class Program
    {
        static void Main(string[] args)
        {
            string pathName = @"C:\DataOfCSharp\myFile.txt";
            var jsonString = File.ReadAllText(pathName);
            var jsonObject = JsonConvert.DeserializeObject<User>(jsonString);
            DataContext.Users.Add(jsonObject);
            

            // path of the file that we want to create
            //string pathName = @"C:\DataOfCSharp\myFile.txt";

            //// create a file at pathName and write "Hello World" to the file
            //File.WriteAllText(pathName, "Hello World");
            //File.WriteAllText(pathName, "Hello Amrah");//ikinci yazilarken birincinin uzerine yazilir burda

            //// read the content of myFile.txt file
            //string readText = File.ReadAllText(pathName);

            //Console.WriteLine(readText);

            //// opens the file at pathName
            //FileStream fs = File.Open(pathName, FileMode.Open);

            //// Create() creates a file at pathName 
            //FileStream files = File.Create(pathName);

            //// check if myFile.txt file is created at the specified path 
            //if (File.Exists(pathName))
            //{
            //    Console.WriteLine("File is created.");
            //}
            //else
            //{
            //    Console.WriteLine("File is not created.");
            //}






            Console.OutputEncoding = Encoding.UTF8; ////Dilleri desteklemek ucun
            Console.InputEncoding = Encoding.UTF8;   ////

            translateWords translateWords = new translateWords();
            while (true)
            {             
                translateWords.ShowMenu();
                translateWords.AddCommand();
                translateWords.LangChoise();
            }
        }
    }
}
