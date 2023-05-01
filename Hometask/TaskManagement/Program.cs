using TaskManagement.Common;
using TaskManagement.Database;
using TaskManagement.LanguageSystem;
using TaskManagement.Language.translator;

namespace TaskManagement
{
    //Encapsulaiton
    public class Program
    {
        static void Main(string[] args)
        {
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
