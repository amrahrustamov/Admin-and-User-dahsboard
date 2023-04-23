using TaskManagement.Common;
using TaskManagement.Database.Models;

namespace TaskManagement.Database
{
    public class DataContext
    {
        public static List<User> Users { get; set; } = new List<User>();
        public static List<Inbox> Messages { get; set; } = new List<Inbox>();
        public static List<HistoryOfRegistration> DatesOfRegister { get; set; } = new List<HistoryOfRegistration>();
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
            Users.Add(new User("Super", "Admin", "123321", "admin@gmail.com", true, false));
            GetTime.GetTimes();
        }
    }
}
