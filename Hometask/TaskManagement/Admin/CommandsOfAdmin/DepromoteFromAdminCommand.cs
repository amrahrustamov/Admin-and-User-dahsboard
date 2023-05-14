using TaskManagement.Database;
using TaskManagement.Database.DataJson;
using TaskManagement.Database.Models;
using TaskManagement.Language.translator;

namespace TaskManagement.Admin.Commands
{
    public class DepromoteFromAdminCommand
    {
        public static void Handle()
        {
            while (true)
            {
                translateWords.AddEmail();
                string email = Console.ReadLine()!;

                 foreach (User user in DataContext.Users)
                 {
                     if (user.Email == email && user.IsAdmin == true)
                     {
                         user.IsAdmin = false;
                        translateWords.BecomeUserInfo();
                        DataOfJson.JSonUserDocRamToFile();
                        return;
                     }
                    if (user.Email == email && user.IsAdmin != true)
                    {
                        translateWords.IsUserInfo();
                    }
                 }
                translateWords.EmailNotFound();
                return;
            }
        }       
    }
}
