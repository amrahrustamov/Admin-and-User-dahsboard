using TaskManagement.Database;
using TaskManagement.Database.Models;
using TaskManagement.Language.translator;
using TaskManagement.LanguageSystem;

namespace TaskManagement.Admin.Commands
{
    public class ShowUserByIdCommand
    {
        public static void Handle()
        {
            while (true)
            {
                try
                {
                    int id = int.Parse(Console.ReadLine()!);

                    foreach (User user in DataContext.Users)
                    {
                        if (user.Id == id)
                        {
                            Console.WriteLine(user.GetShortInfo());
                            return;
                        }
                    }

                    Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.emailNotFound));
                }
                catch 
                {
                    Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.invalidCommand));
                }
            }
        }
    }
}
