using TaskManagement.Database.Models;
using TaskManagement.Database;
using TaskManagement.Database.DataJson;

namespace TaskManagement.Admin.Commands
{
    public class BanUserCommand
    {
        
        public static void Handle()
        {
            Console.Write("Add email : ");
            string email = Console.ReadLine()!;

            foreach (User user in DataContext.Users)
            {
                if (user.Email == email)
                {
                    if (user.IsAdmin == true)
                    {
                        Console.WriteLine("This email is owned by an admin");
                        return;
                    }
                    user.IsDeactive = true;
                    DataOfJson.JSonUserDocRamToFile();
                    return;
                }
            }
            Console.WriteLine("Email not found");
            return;
        }
    }
}
