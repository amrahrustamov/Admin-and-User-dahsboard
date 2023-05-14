using TaskManagement.Database.Models;
using TaskManagement.Language.translator;
using TaskManagement.Database;
using System.Reflection.Metadata;

namespace TaskManagement.Client.CommandOfClient
{
    public  class CommentToBlog
    {
        public static void Handle(User user)
        {
            while(true)
            {
                translateWords.AddCodeOfBlog();
                string commandCode = Console.ReadLine()!;
                translateWords.AddCommentTextToBlog();
                string addComment = Console.ReadLine()!;

                foreach (Blog blogout in DataContext.Blogs)
                    if (blogout.Code == commandCode)
                    {
                        Comments comments = new Comments(addComment, commandCode, user, DateTime.Now);
                        DataContext.Comments.Add(comments);
                        return;
                    }
            }

        }
    }
}
