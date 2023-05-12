using TaskManagement.Database;
using TaskManagement.Database.DataJson;
using TaskManagement.Database.Models;
using TaskManagement.Language.translator;

namespace TaskManagement.Admin.Commands
{
    public class PromoteToAdminCommand
    {
        public static void Handle()
        {
            while (true)
            {
                translateWords.AddEmail();
                string email = Console.ReadLine()!;

                foreach (User user in DataContext.Users)
                {
                    if (user.Email == email && user.IsAdmin != true)
                    {
                        user.IsAdmin = true;
                        translateWords.BecomeAdminInfo();
                        DataOfJson.JSonDocRamToFile();
                        return;
                    }
                    if (user.Email == email && user.IsAdmin == true)
                    {
                        translateWords.IsAdminInfo();
                        return;
                    }
                }
                translateWords.EmailNotFound();
                return;
            }
        }
    }
}
