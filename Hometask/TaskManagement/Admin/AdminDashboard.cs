using TaskManagement.Admin.Commands;
using TaskManagement.Database.Models;
using TaskManagement.Language.translator;

namespace TaskManagement.Admin
{
    public class AdminDashboard
    {
        public static void Introduction(User user)
        {
                Console.WriteLine($"Hello dear admin : {user.Name} {user.LastName}");

            while (true)
            {
                translateWords.ShowUser();
                translateWords.ShowUserByEmail();
                translateWords.ShowUserById();
                translateWords.AddUser();
                translateWords.PromoteToAdmin();
                translateWords.DepromoteToAdmin();
                translateWords.UpdateUserSetting();
                translateWords.RemoveUser();
                translateWords.BanUser();
                translateWords.SendMessageTo();
                translateWords.CheckBlogs();
                translateWords.Logout();

                translateWords.AddCommand();
                string command = Console.ReadLine()!;

                switch (command)
                { 
                    case "/show-users":
                        ShowUsersCommand.Handle();
                        break;
                    case "/show-user-by-email":
                        ShowUserByEmailCommand.Handle();
                        break;
                    case "/show-user-by-id":
                        ShowUserByIdCommand.Handle();
                        break;
                    case "/add-user":
                        AddUserCommand.Handle();
                        break;
                    case "/promote-to-admin":
                        PromoteToAdminCommand.Handle();
                        break;
                    case "/depromote-from-admin":
                        DepromoteFromAdminCommand.Handle();
                        break;
                    case "/update-user-setting":
                        AddUpdateSettingCommand.Handle(user);
                        break;
                    case "/remove-user":
                        RemoveUserByEmail.Handle();
                        break;
                    case "/ban-user":
                        BanUserCommand.Handle();
                        break;
                    case "/check-blogs":
                        CheckBlogsCommand.Handle();
                        break;
                    case "/message-to":
                        MessageToCommand.Handle();
                        break;
                    case "/logout":
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
