using TaskManagement.Database;
using TaskManagement.Database.DataJson;
using TaskManagement.Database.Models;
using TaskManagement.Language.translator;
using TaskManagement.LanguageSystem;

namespace TaskManagement.Admin.Commands
{
    public class DepromoteFromAdminCommand
    {
        public static void Handle()
        {
            while (true)
            {
                Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.addEmail));
                string email = Console.ReadLine()!;

                 foreach (User user in DataContext.Users)
                 {
                     if (user.Email == email && user.IsAdmin == true)
                     {
                         user.IsAdmin = false;
                        Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.becomeUserInfo));
                        DataOfJson.JSonUserDocRamToFile();
                        return;
                     }
                    if (user.Email == email && user.IsAdmin != true)
                    {
                        Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.isUserInfo));
                    }
                 }
                Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.emailNotFound));
                return;
            }
        }       
    }
}
