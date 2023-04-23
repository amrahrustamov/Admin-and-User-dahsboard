using TaskManagement.Admin;
using TaskManagement.Client;
using TaskManagement.Database;
using TaskManagement.Database.Models;

namespace TaskManagement.Common
{
    public class LoginCommand
    {
        public static void Handle() //use alias
        {
            Console.WriteLine("");
            Console.Write("Add email : ");
            string email = Console.ReadLine()!;
            Console.Write("Add password : ");
            string password = Console.ReadLine()!;

            for (int i = 0; i < DataContext.Users.Count; i++)
            {
                User user = DataContext.Users[i];

                if (User.Email == email && user.Password == password && user.IsDeactive == false)
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
