using TaskManagement.Database;
using TaskManagement.Database.Models;

namespace TaskManagement.Admin.Commands
{
    public class PromoteToAdminCommand
    {
        public static void Handle()
        {
            while (true)
            {
                Console.Write("Add email : ");
                string email = Console.ReadLine()!;

                foreach (User user in DataContext.Users)
                {
                    if (user.Email == email && user.IsAdmin != true)
                    {
                        user.IsAdmin = true;
                        Console.WriteLine("The owner of this email has become an admin");
                        return;
                    }
                    if (user.Email == email && user.IsAdmin == true)
                    {
                        Console.WriteLine("The owner of this email is already admin");
                        return;
                    }
                }
                Console.WriteLine("Email not found");
                return;
            }
        }
    }
}
