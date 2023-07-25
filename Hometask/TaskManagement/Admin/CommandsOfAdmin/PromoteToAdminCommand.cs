using TaskManagement.Database;
using TaskManagement.Database.DataJson;
using TaskManagement.Database.Models;
using TaskManagement.Language.translator;
using TaskManagement.LanguageSystem;

namespace TaskManagement.Admin.Commands
{
    public class PromoteToAdminCommand
    {
        public static void Handle()
        {
            while (true)
            {
                Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.addEmail));
                string email = Console.ReadLine()!;

                foreach (User user in DataContext.Users)
                {
                    if (user.Email == email && user.IsAdmin != true)
                    {
                        user.IsAdmin = true;
                        Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.becomeAdminInfo));
                        DataOfJson.JSonUserDocRamToFile();
                        return;
                    }
                    if (user.Email == email && user.IsAdmin == true)
                    {
                        Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.isAdminInfo));
                        return;
                    }
                }
                Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.emailNotFound));
                return;
            }
        }
    }
}
