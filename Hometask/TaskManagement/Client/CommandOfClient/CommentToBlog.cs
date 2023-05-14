using TaskManagement.Database.Models;
using TaskManagement.Language.translator;
using TaskManagement.Database;
using System.Reflection.Metadata;
using static System.Net.Mime.MediaTypeNames;
using System.Linq;
using TaskManagement.Common;
using System.Security.Cryptography.X509Certificates;

namespace TaskManagement.Client.CommandOfClient
{
    public  class CommentToBlog
    {
        public static void Handle(User user)
        {
            while(true)
            {
                translateWords.AddCodeOfBlog();
                string AddCode = Console.ReadLine()!;
                translateWords.AddCommentTextToBlog();
                string addComment = Console.ReadLine()!;
              
                UserValidator userValidator = new UserValidator();

                 CheckCode(AddCode);
                            
                if(userValidator.CheckCommentContains(addComment) && userValidator.CheckCommentLength(addComment))
                {
                    Comments comments = new Comments(addComment, AddCode, user, DateTime.Now);
                    DataContext.Comments.Add(comments);
                    translateWords.SuccesAddComment();
                    SendNoticeMessage(user, AddCode);
                    return;
                }
                translateWords.UnsuccesCommentNotice();
            }
        }
        public static bool CheckCode(string AddCode)
        {
            foreach (Blog item in DataContext.Blogs)
            {
                if (item.Code == commandCode)
                    return true;
            }
            translateWords.NotFoundBlogByCode();
            return false;
        }
        public static void SendNoticeMessage(User user,string AddCode)
        {
            string sender = user.Name + user.LastName + user.Email;
            string recipient;
            string message = $"<{AddCode}> kodlu vlogunuza <{user.Name}> <{user.LastName}> terefinden rey elave olundu.";

            foreach (Blog item in DataContext.Blogs)
            {
                if (item.Code == AddCode)
                {
                    recipient = item.Owner.Email;
                    Inbox inbox = new Inbox(sender, recipient, message);
                    DataContext.Messages.Add(inbox);
                    return;
                }
            }
        }
    }
}
