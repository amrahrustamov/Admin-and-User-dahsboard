using TaskManagement.Database;
using TaskManagement.Database.Models;
using TaskManagement.Language.translator;
using TaskManagement.Database.DataJson;
using TaskManagement.LanguageSystem;

namespace TaskManagement.Common
{
    public class RegisterCommand
    {
        public static void Handle()
        {            

            UserValidator userValidator = new UserValidator();

            Console.WriteLine("");
            string firstName = userValidator.GetAndValidateFirstName();
            string lastName  = userValidator.GetAndValidateLastName();
            string password  = userValidator.GetAndValidatePassword();
            string email     = userValidator.GetAndValidateEmail();
            Console.WriteLine("");
            User human = new User(firstName, lastName, password, email);
            DataContext.Users.Add(human);
            DataOfJson.JSonUserDocRamToFile(); //for adding data from Ram to SSD
            Console.WriteLine( LocalizationService.GetTranslation(TranslationKey.succesRegistr));
        }
    }
}
