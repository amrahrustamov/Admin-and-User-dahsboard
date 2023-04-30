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
            foreach (Blog blog in DataContext.Blogs)
            {
                if(blog.Status == BlogStatus.Created)
                {
                    Console.WriteLine($"Blog ID : {blog.Id} Blog name : {blog.Title} Blog status : {blog.Status}");
                    Console.WriteLine("Blog : ");
                    Console.WriteLine(blog.Content);                                                    
                }
            }
        }       
    }
}
