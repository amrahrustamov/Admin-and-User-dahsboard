using TaskManagement.Language.translator;
using System.Text;
using TaskManagement.Database.DataJson;
using TaskManagement.Database;

namespace TaskManagement
{
    //Encapsulaiton
    public class Program
    {
        static void Main(string[] args)
        {           
            DataContext.AddUserSeeedings();

            DataOfJson.JsonUserDocFileToRam();
            DataOfJson.JsonMessageDocFileToRam();
            DataOfJson.JsonBlogsDocFileToRam();
            DataOfJson.JsonCommentDocFileToRam();

                    //Dilleri desteklemek ucun
            Console.OutputEncoding = Encoding.UTF8; 
            Console.InputEncoding = Encoding.UTF8;   

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
