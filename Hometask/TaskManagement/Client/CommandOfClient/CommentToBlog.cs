using TaskManagement.Language.translator;

namespace TaskManagement.Client.CommandOfClient
{
    public  class CommentToBlog
    {
        public static void Handle()
        {
            translateWords.AddCodeOfBlog();
            string addBlogCode = Console.ReadLine()!;
            translateWords.AddCommentTextToBlog();
            string addComment = Console.ReadLine()!;
        }
    }
}
