
namespace TaskManagement.Database.Models
{
    public class Inbox
    {
        public Inbox(string sender, string recipient, string message)
        {
            Sender = sender;
            Recipient = recipient;
            Message = message;
        }
        public string Sender { get; set; }
        public string Recipient { get; set; }
        public string Message { get; set; }
    }
}
