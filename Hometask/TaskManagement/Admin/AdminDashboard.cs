using TaskManagement.Admin.Commands;
using TaskManagement.Database.Models;

namespace TaskManagement.Admin
{
    public class AdminDashboard
    {
        public static void Introduction(User user)
        {
                Console.WriteLine($"Hello dear admin : {user.Name} {user.LastName}");

            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("/show-users");
                Console.WriteLine("/show-user-by-email");
                Console.WriteLine("/show-user-by-id");
                Console.WriteLine("/add-user");
                Console.WriteLine("/promote-to-admin");
                Console.WriteLine("/depromote-from-admin");
                Console.WriteLine("/update-user-setting");
                Console.WriteLine("/remove-user");
                Console.WriteLine("/ban-user");
                Console.WriteLine("/message-to");
                Console.WriteLine("/logout");
                Console.WriteLine("");

                Console.Write("Add command : ");
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
                    case "/message-to":
                        MessageToCommand.Handle();
                        break;
                    case "/logout":
                        Console.WriteLine("Bye-bye");
                        return;
                    default:
                        Console.WriteLine("Invalid command, pls try again");
                        break;
                }
            }
        }
    }
}
