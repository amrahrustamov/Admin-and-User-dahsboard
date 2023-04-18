using TaskManagement.Admin.Commands;
using TaskManagement.Database.Models;

namespace TaskManagement.Client
{
    public class ClientDashboard
    {
        public static void Introduction(User user) 
        {
            Console.WriteLine($"Hello! : {user.Name} {user.LastName}");

            while (true)
            {
                  Console.WriteLine("");
                  Console.WriteLine("/update-settings");
                  Console.WriteLine("/close-account");
                  Console.WriteLine("/messages");
                  Console.WriteLine("");              

                Console.Write("Add command : ");
                string command = Console.ReadLine()!;

                switch (command)
                {
                    case "/update-settings":
                        AddUpdateSettingCommand.Handle(user);
                        return;
                    case "/close-account":
                        RemoveUserByEmail.Handle();
                        return;
                    case "/messages":
                        Messages.Handle(user.Email);
                        return;
                    default:
                        Console.WriteLine("Invalid input, pls try again");
                        break;
                }
            }
        }
    }
}
