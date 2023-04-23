using TaskManagement.Database;
using TaskManagement.Database.Models;

namespace TaskManagement.Admin.Commands
{
    public class ShowUserByEmailCommand
    {
        public static void Handle()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Add email : ");
                    string emailForSearch = Console.ReadLine()!;

                    foreach (User user in DataContext.Users)
                    {
                        if (User.Email == emailForSearch)
                        {
                            Console.WriteLine(user.GetShortInfo());
                            return;
                        }
                    }
                    Console.WriteLine("Email not found");
                }
                catch 
                {
                    Console.WriteLine("Invalid input pls try again");
                }
            }
        }
    }
}
