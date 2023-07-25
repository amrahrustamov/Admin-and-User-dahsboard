using TaskManagement.Database;
using TaskManagement.Database.Models;
using TaskManagement.Language.translator;
using TaskManagement.LanguageSystem;

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
                    Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.invalidCommand));
                    string emailForSearch = Console.ReadLine()!;

                    foreach (User user in DataContext.Users)
                    {
                        if (user.Email == emailForSearch)
                        {
                            Console.WriteLine(user.GetShortInfo());
                            return;
                        }
                    }
                    Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.invalidCommand));
                }
                catch 
                {
                    Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.invalidCommand));
                }
            }
        }
    }
}
