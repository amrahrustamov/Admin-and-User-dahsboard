using TaskManagement.Database.Models;
using TaskManagement.Language.translator;
using TaskManagement.Database;
using TaskManagement.Common;
using TaskManagement.Database.DataJson;
using System;
using System.Reflection;
using System.Xml.Linq;
using TaskManagement.LanguageSystem;

namespace TaskManagement.Client.CommandOfClient
{
    public  class CommentToBlog
    {
        public static void Handle(User user)
        {
            while(true)
            {
                Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.addCodeOfBlog));
                string AddCode = Console.ReadLine()!;
                Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.addCommentTextToBlog));
                string addComment = Console.ReadLine()!;
              
                UserValidator userValidator = new UserValidator();

                 CheckCode(AddCode);
                            
                if(userValidator.CheckCommentContains(addComment) && userValidator.CheckCommentLength(addComment)&& CheckCode(AddCode))
                {                 
                    List<CommentConstructor> myComment = new List<CommentConstructor>();
                    CommentConstructor comment = new CommentConstructor(addComment, AddCode, user, DateTime.Now);
                    DataContext.Comments.Add(comment);
                    DataOfJson.JSonCommentDocRamToFile();
                    Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.succesAddComment));
                    SendNoticeMessage(user, AddCode);
                    return;
                }
                Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.unsuccesCommentNotice));
            }
        }
        public static bool CheckCode(string AddCode)
        {
            if(DataContext.Blogs.Count == 0)
            {
                Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.notFoundBlogByCode));
                return false;
            }

            foreach (Blog item in DataContext.Blogs)
            {
                if (item.Code == AddCode)
                    return true;
            }
            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.notFoundBlogByCode));
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
