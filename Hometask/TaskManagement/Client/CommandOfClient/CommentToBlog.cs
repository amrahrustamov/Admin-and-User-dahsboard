using TaskManagement.Database.Models;
using TaskManagement.Language.translator;
using TaskManagement.Database;
using TaskManagement.Common;
using TaskManagement.Database.DataJson;
using System;
using System.Reflection;
using System.Xml.Linq;

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
                            
                if(userValidator.CheckCommentContains(addComment) && userValidator.CheckCommentLength(addComment)&& CheckCode(AddCode))
                {                 
                    List<CommentConstructor> myComment = new List<CommentConstructor>();
                    CommentConstructor comment = new CommentConstructor(addComment, AddCode, user, DateTime.Now);
                    DataContext.Comments.Add(comment);
                    DataOfJson.JSonCommentDocRamToFile();
                    translateWords.SuccesAddComment();
                    SendNoticeMessage(user, AddCode);
                    return;
                }
                translateWords.UnsuccesCommentNotice();
            }
        }
        public static bool CheckCode(string AddCode)
        {
            if(DataContext.Blogs.Count == 0)
            {
                translateWords.NotFoundBlogByCode();
                return false;
            }

            foreach (Blog item in DataContext.Blogs)
            {
                if (item.Code == AddCode)
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
                    List<Inbox> myObjects = new List<Inbox>();
                    Inbox inbox = new Inbox(sender, recipient, message);
                    DataContext.Messages.Add(inbox);
                    DataOfJson.JsonMessageDocFileToRam();
                    return;
                }
            }       
        }
    }
}
