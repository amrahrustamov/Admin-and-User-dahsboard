using TaskManagement.Database.Models;

namespace TaskManagement.Database
{
    public class DataContext
    {
        public static List<User> Users { get; set; } = new List<User>();
        public static List<Inbox> Messages { get; set; } = new List<Inbox>();
        public static List<Blog> Blogs { get; set; } = new List<Blog>();
        public static List<CommentConstructor> Comments { get; set; } = new List<CommentConstructor>();

        public DataContext()
        {
            AddUserSeeedings();
        }
        public static void AddUserSeeedings()
        {
            Users.Add(new User("Amrah", "Rustamov", "start123", "amrahrustamov94@code.edu.az", true, false));
        }
    }
}