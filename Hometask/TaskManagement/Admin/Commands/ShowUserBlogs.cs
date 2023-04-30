using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Database.Models;
using TaskManagement.Database;

namespace TaskManagement.Admin.Commands
{
    public class ShowUserBlogs
    {
        public static void Handle()
        {
            for (int i = 0; i < DataContext.Blogs.Count; i++)
            {
                Blog blog = DataContext.Blogs[i];

                Console.WriteLine($"Sender : {blog.Owner.Name} Blog name : {blog.Title} Blog ID : {blog.Id} ");
                Console.WriteLine(blog.Content);                                  
            }
        }       
    }
}
