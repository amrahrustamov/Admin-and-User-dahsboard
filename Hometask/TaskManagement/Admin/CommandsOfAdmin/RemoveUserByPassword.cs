using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Database.Models;
using TaskManagement.Database;

namespace TaskManagement.Admin.Commands
{
    internal class RemoveUserByPassword
    {
        public static void Handle()
        {
            Console.Write("Add email : ");
            string email = Console.ReadLine()!;
            Console.Write("Add password : ");
            string password = Console.ReadLine()!;

            foreach (User user in DataContext.Users)
            {
                if (user.Email == email && user.Password == password)
                {
                    if (user.IsAdmin == true)
                    {
                        Console.WriteLine("This email is owned by an admin");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("");
                        DataContext.Users.Remove(user);
                    }
                    return;
                }
            }
            Console.WriteLine("Invalid input!");
            return;
        }
    }
}
