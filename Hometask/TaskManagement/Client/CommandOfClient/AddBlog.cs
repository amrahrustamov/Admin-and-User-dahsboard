using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Common;
using TaskManagement.Database;
using TaskManagement.Database.Models;
using TaskManagement.Services;

namespace TaskManagement.Client.CommandOfClient
{
    public class AddBlog
    {
        public static void AddBlogs()
        {
            Console.Write("Add blog title in Azerbaijani : ");
            string title_Az = Console.ReadLine()!;
            Console.Write("Add blog title in Russian : ");
            string title_Ru = Console.ReadLine()!;
            Console.Write("Add blog title in English : ");
            string title_En = Console.ReadLine()!;

            Console.Write("Add blog content in Azerbaijani : ");
            string content_Az = Console.ReadLine()!;
            Console.Write("Add blog content in Russian : ");
            string content_Ru = Console.ReadLine()!;
            Console.Write("Add blog content in English : ");
            string content_En = Console.ReadLine()!;

            Blog blog = new Blog(title_Az, title_Ru, title_En, content_Az, content_Ru, content_En, UserServices.CurrentUser, DateTime.Now, BlogStatus.Created);
            DataContext.Blogs.Add(blog);
        }
    }
}
