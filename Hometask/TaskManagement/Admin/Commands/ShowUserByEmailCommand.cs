using TaskManagement.Database;
using TaskManagement.Database.Models;
using TaskManagement.Language.translator;

namespace TaskManagement.Admin.Commands
{
    public class ShowUserByEmailCommand
    {
        public static void Handle()
        {
            while (true)
            {
                try
                {
                    translateWords.AddEmail();
                    string emailForSearch = Console.ReadLine()!;

                    foreach (User user in DataContext.Users)
                    {
                        if (user.Email == emailForSearch)
                        {
                            Console.WriteLine(user.GetShortInfo());
                            return;
                        }
                    }
                    translateWords.EmailNotFound();
                }
                catch 
                {
                    translateWords.InvalidCommand();
                }
            }
        }
    }
}
