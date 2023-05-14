using TaskManagement.Database.Models;

namespace TaskManagement.Database
{
    public class DataContext
    {
        public static List<User> Users { get; set; } = new List<User>();
        public static List<Inbox> Messages { get; set; } = new List<Inbox>();
        public static List<Blog> Blogs { get; set; } = new List<Blog>();
        public static List<Comments> Comments { get; set; } = new List<Comments>();

        public DataContext()
        {
            AddUserSeeedings();
        }
        private static void AddUserSeeedings()
        {
            Users.Add(new User("Amrah", "Rustamov", "start123", "amrahrustamov94@code.edu.az", true, false));
            Users.Add(new User("Hilal", "Aliyev", "Hilal1994", "hilalaliyev94@code.edu.az", false, false));
        }
    }
}
