using TaskManagement.Language.translator;
using System.Text;
using TaskManagement.Database.DataJson;

namespace TaskManagement
{
    //Encapsulaiton
    public class Program
    {
        static void Main(string[] args)
        {
            DataOfJson.JsonUserDocFileToRam();

            Console.OutputEncoding = Encoding.UTF8; ////Dilleri desteklemek ucun
            Console.InputEncoding = Encoding.UTF8;   ////

            translateWords translateWords = new translateWords();
             while(true)
            {
                translateWords.ShowMenu();
                translateWords.AddCommand();
                string command = Console.ReadLine()!;
                translateWords.LangChoise(command);

                if (command == "/cixis" || command == "/выход" || command == "/exit")
                    break;
            }
        }
    }
}
