using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Database.Models;
using TaskManagement.Database;
using TaskManagement.Language.translator;
using TaskManagement.LanguageSystem;

namespace TaskManagement
{
    public class BlogAndComment
    {
        public static void Handle()
        {
            foreach (Blog blog in DataContext.Blogs)
            {
                if (blog.Status == BlogStatus.Approved)
                {
                    Console.WriteLine($"{blog.CreatedAt} | {blog.Code} | {blog.Owner.Name} {blog.Owner.LastName}");
                    Console.WriteLine("############################################################");

                        //Title
                    if (Translate.Language == CurrentLanguage.Ru)
                        Console.WriteLine($"=== {blog.Title_Ru} ===");
                    if (Translate.Language == CurrentLanguage.En)
                        Console.WriteLine($"=== {blog.Title_En} ===");
                    else
                        Console.WriteLine($"=== {blog.Title_Az} ===");

                        //Content
                    if (Translate.Language == CurrentLanguage.Ru)
                        Console.WriteLine($"=== {blog.Content_Ru} ===");
                    if (Translate.Language == CurrentLanguage.En)
                        Console.WriteLine($"=== {blog.Content_En} ===");
                    else
                        Console.WriteLine($"=== {blog.Content_Az} ===");

                    foreach(Comments item in DataContext.Comments)
                    {
                        if(item.CodeOfBlog == blog.Code)
                        {
                            int i = 1;
                            Console.WriteLine($"{i}.[{item.DateTime}] [{item.Owner.Name} {item.Owner.LastName}] - {item.Text}");
                            i++;
                        }
                    }
                }
            }
        }
    }
}
