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
                     if (user.Email == email)
                     {
                         user.IsAdmin = false;
                         Console.WriteLine("The owner of this email already is not an admin");
                         return;
                     }
                 }
                 Console.WriteLine("Email not found");
                 return;
            }
        }       
    }
}
