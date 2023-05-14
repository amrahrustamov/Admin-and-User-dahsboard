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
                }
            }
        }
        public static bool CheckCode(string commandCode)
        {
            foreach (Blog item in DataContext.Blogs)
            {
                if (item.Code == commandCode)
                    return true;
            }
            return false;
        }
    }
}
