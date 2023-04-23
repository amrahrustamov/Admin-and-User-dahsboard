using TaskManagement.Database;
using TaskManagement.Database.Models;

namespace TaskManagement.Admin.Commands
{
    public class DepromoteFromAdminCommand
    {
        public static void Handle()
        {
            while (true)
            {
                 Console.Write("Add email : ");
                 string email = Console.ReadLine()!;

                 foreach (User user in DataContext.Users)
                 {
                     if (User.Email == email && user.IsAdmin == true)
                     {
                         user.IsAdmin = false;
                        Console.WriteLine("The owner of this email has become user");
                        return;
                     }
                    if (User.Email == email && user.IsAdmin != true)
                    {
                        Console.WriteLine("The owner of this email already is user");
                    }
                 }
                 Console.WriteLine("Email not found");
                 return;
            }
        }       
    }
}
