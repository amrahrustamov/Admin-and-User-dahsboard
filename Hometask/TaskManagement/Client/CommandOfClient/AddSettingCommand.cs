using TaskManagement.Database;
using TaskManagement.Database.Models;
using TaskManagement.Common;
using TaskManagement.Database.DataJson;

namespace TaskManagement.Client.CommandOfClient
{
    public class AddUpdateSettingCommand
    {
        public static void Handle(User user)
        {
            UserValidator userValidator = new UserValidator();

            string firstName = userValidator.GetAndValidateFirstName();
            string lastName = userValidator.GetAndValidateLastName();
            string password = userValidator.GetAndValidatePassword();

            user.Name = firstName;
            user.LastName = lastName;
            user.Password = password;
            DataOfJson.JSonUserDocRamToFile();
        }
    }
}
