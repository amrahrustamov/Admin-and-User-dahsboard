using TaskManagement.Database;
using TaskManagement.Database.Models;
using TaskManagement.Common;

namespace TaskManagement.Admin.Commands
{
    public class AddUpdateSettingCommand
    {
        public static void Handle()
        {
            Console.Write("Add email : ");
            string email = Console.ReadLine()!;

            foreach (User user in DataContext.Users)
            {
                if (user.Email == email)
                {
                    UserValidator userValidator = new UserValidator();

                    string firstName = userValidator.GetAndValidateFirstName();
                    string lastName  = userValidator.GetAndValidateLastName();
                    string password  = userValidator.GetAndValidatePassword();

                    user.Name     = firstName;
                    user.LastName = lastName;
                    user.Password = password;
                    return;
                }
            }
            Console.WriteLine("Email not found");
            return;
        }
    }
}
