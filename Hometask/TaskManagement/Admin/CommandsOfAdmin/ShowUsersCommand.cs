using TaskManagement.Database;
using TaskManagement.Database.Models;

namespace TaskManagement.Admin.Commands
{
    public class ShowUsersCommand
    {
        public static void Handle()
        {
            int order = 1;

            foreach (User user in DataContext.Users)
            {
                Console.WriteLine($"{order}. {user.GetShortInfo()}");
                order++;
            }
        }
    }
}
