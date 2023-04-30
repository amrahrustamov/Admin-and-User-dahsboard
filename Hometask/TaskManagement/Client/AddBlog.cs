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

namespace TaskManagement.Client
{
    public class AddBlog
    {
        public static void AddBlogs()
        {
            Console.Write("Add blog name : ");
            string name = Console.ReadLine()!;

            Console.Write("Add blog : ");
            string text = Console.ReadLine()!;

            Blog blog = new Blog(name, text, UserServices.CurrentUser, BlogStatus.Created);
            DataContext.Blogs.Add(blog);
        }
    }
}
