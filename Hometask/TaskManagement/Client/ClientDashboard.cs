using TaskManagement.Admin.Commands;
using TaskManagement.Client.CommandOfClient;
using TaskManagement.Database.Models;
using TaskManagement.Language.translator;
using TaskManagement.LanguageSystem;

namespace TaskManagement.Client
{
    public class ClientDashboard
    {
        public static void Introduction(User user) 
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.helloAdmin));
            Console.WriteLine($" : {user.Name} {user.LastName}");
            Console.WriteLine("");

            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.updateUserSetting));
                Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.closeAccount));
                Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.messages));
                Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.addBlog));
                Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.addComments));           
                Console.WriteLine("");

                Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.addCommand));  
                string command = Console.ReadLine()!;

                if (Translate.Language == CurrentLanguage.Az)
                {
                     switch (command)
                     {
                        case "/istifadeci-parametrini-yenile":
                            AddUpdateSettingCommand.Handle(user);
                            return;
                        case "/Hesabi-baglayin":
                            RemoveUserByEmail.Handle();
                            return;
                        case "/Mesajlar":
                            Messages.Handle(user.Email!);
                            return;
                        case "/Blog-elave-et":
                            AddBlog.Handle(user);
                            return;
                        case "/serh-elave-et":
                            CommentToBlog.Handle(user);
                            return;
                        case "/cixis":
                            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.byeBye)); 
                            return;
                        default:
                            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.invalidCommand));
                            break;
                     }
                }
                if (Translate.Language == CurrentLanguage.Ru)
                {
                    switch (command)
                    {
                        case "/обновить настройки пользователя":
                            AddUpdateSettingCommand.Handle(user);
                            return;
                        case "/Закрыть аккаунт":
                            RemoveUserByEmail.Handle();
                            return;
                        case "/Сообщения":
                            Messages.Handle(user.Email!);
                            return;
                        case "/Добавить блог":
                            AddBlog.Handle(user);
                            return;
                        case "/выйти":
                            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.byeBye));
                            return;
                        default:
                            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.invalidCommand));
                            break;
                    }
                }
                if (Translate.Language == CurrentLanguage.En)
                {
                    switch (command)
                    {
                        case "/update-settings":
                            AddUpdateSettingCommand.Handle(user);
                            return;
                        case "/close-account":
                            RemoveUserByEmail.Handle();
                            return;
                        case "/messages":
                            Messages.Handle(user.Email!);
                            return;
                        case "/add-blog":
                            AddBlog.Handle(user);
                            return;
                        case "/exit":
                            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.byeBye));
                            return;
                        default:
                            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.invalidCommand));
                            break;
                    }
                }
            }
        }
    }
}
