using TaskManagement.Common;
using TaskManagement.Database;
using TaskManagement.LanguageSystem;
using TaskManagement.Language.translator;
using System.Text;

namespace TaskManagement
{
    //Encapsulaiton
    public class Program
    {
        static void Main(string[] args)
        {
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
