using System.Reflection.Metadata;
using TaskManagement.Common;
using TaskManagement.Database.Models;

namespace TaskManagement.Database
{
    public class DataContext
    {
        public static List<User> Users { get; set; } = new List<User>();
        public static List<Inbox> Messages { get; set; } = new List<Inbox>();
        public static List<Blog> Blogs { get; set; } = new List<Blog>();
        static DataContext()
        {
            AddUserSeeedings();
        }
        public DataContext()
        {
            AddUserSeeedings();
        }
        private static void AddUserSeeedings()
        {
            Users.Add(new User("Amrah", "Rustamov", "Bjk039423", "amrahrustamov94@code.edu.az", true, false));
        }
    }
}
