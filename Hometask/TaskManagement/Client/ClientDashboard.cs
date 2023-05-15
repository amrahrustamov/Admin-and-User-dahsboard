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
            translateWords.HelloAdmin();
            Console.WriteLine($" : {user.Name} {user.LastName}");
            Console.WriteLine("");

            while (true)
            {
                Console.WriteLine("");
                translateWords.UpdateUserSetting();
                translateWords.CloseAccount();
                translateWords.Messages();
                translateWords.AddBlog();
                translateWords.AddComments();
                Console.WriteLine("");

                translateWords.AddCommand();
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
                            translateWords.ByeBye();
                            return;
                        default:
                            translateWords.InvalidCommand();
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
                            translateWords.ByeBye();
                            return;
                        default:
                            translateWords.InvalidCommand();                           
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
                            translateWords.ByeBye();
                            return;
                        default:
                            translateWords.InvalidCommand();
                            break;
                    }
                }
            }
        }
    }
}
