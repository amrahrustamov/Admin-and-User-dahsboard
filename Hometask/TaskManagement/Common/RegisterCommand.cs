using System.Text.Json;
using System;
using TaskManagement.Database;
using TaskManagement.Database.Models;
using TaskManagement.Language.translator;
using TaskManagement.Utilities;
using TaskManagement.Database.DataJson;

namespace TaskManagement.Common
{
    public class RegisterCommand
    {
        public static void Handle()
        {            

            UserValidator userValidator = new UserValidator();  ///instance

            Console.WriteLine("");
            string firstName = userValidator.GetAndValidateFirstName();
            string lastName  = userValidator.GetAndValidateLastName();
            string password  = userValidator.GetAndValidatePassword();
            string email     = userValidator.GetAndValidateEmail();
            Console.WriteLine("");
            User human = new User(firstName, lastName, password, email);
            DataContext.Users.Add(human);
            DataOfJson.JSonDocRamToFile(); //for adding data from Ram to SSD
            translateWords.SuccesRegistr();
        }
    }
}
