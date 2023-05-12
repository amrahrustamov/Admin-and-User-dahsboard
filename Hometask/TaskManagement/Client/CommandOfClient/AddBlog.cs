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
        public static void Handle()
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

            string code = RandomCode();

            Blog blog = new Blog(code, title_Az, title_Ru, title_En, content_Az, content_Ru, content_En, UserServices.CurrentUser, DateTime.Now, BlogStatus.Created);
            DataContext.Blogs.Add(blog);
        }
        public static string RandomCode()
        {  
            Random rnd = new Random(); //Random kod yaradildi

            int testCode = rnd.Next(10000, 100000);
            string code = $"BL{testCode}";
                     
            foreach (Blog blog  in DataContext.Blogs)
            {
                if(blog.Code == code)
                   RandomCode();
            }
            return code;
        }      
    }
}
