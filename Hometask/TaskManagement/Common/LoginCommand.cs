using TaskManagement.Admin;
using TaskManagement.Client;
using TaskManagement.Database;
using TaskManagement.Database.Models;
using TaskManagement.Language.translator;
using TaskManagement.LanguageSystem;

namespace TaskManagement.Common
{
    public class LoginCommand
    {
        public static void Handle() //use alias
        {
            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.addEmail));
            string email = Console.ReadLine()!;
            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.addPassword));
            string password = Console.ReadLine()!;

            for (int i = 0; i < DataContext.Users.Count; i++)
            {
                User user = DataContext.Users[i];

                if (user.Email == email && user.Password == password && user.IsDeactive == false)
                {
                    if (user.IsAdmin)
                    {
                        AdminDashboard.Introduction(user);
                        return;
                    }
                    else
                    {
                        ClientDashboard.Introduction(user);
                        return;
                    }
                }
            }
        }
    }
}
