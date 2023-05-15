using TaskManagement.Common;
using TaskManagement.Database;
using TaskManagement.Database.DataJson;
using TaskManagement.Database.Models;

namespace TaskManagement.Admin.Commands
{
    public class MessageToCommand
    {
        public static void Handle(User user)
        {
            UserValidator userValidator = new UserValidator();

            string sender = user.Email;
            string recipient = userValidator.SendMessageByEmail();
            string message = userValidator.CheckMessage();
           
            Inbox inbox = new Inbox(sender, recipient, message);
            DataContext.Messages.Add(inbox);
            DataOfJson.JsonMessageDocFileToRam();
        }
    }
}
