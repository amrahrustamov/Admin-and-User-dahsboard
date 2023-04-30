using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Admin.Commands
{
    public class CheckBlogsCommand
    {
        public static void Handle()
        {
            Console.WriteLine("/Show-blogs");
            Console.WriteLine("/aprove-blogs");

            string command = Console.ReadLine()!;

            switch (command)
            {
                case "/Show-blogs":
                    ShowUserBlogs.Handle();
                    break;
                case "/Aprove-blogs":
                    AproveBlogs.Handle();
                    break;
            }
        }
    }
}
