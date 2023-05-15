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
            try
            {
                foreach (Blog obj in DataContext.Blogs)
                {
                    if (obj.Status == BlogStatus.Approved)
                    {
                        Console.WriteLine($"{obj.CreatedAt} | {obj.Code} | {obj.Owner.Name} {obj.Owner.LastName}");
                        Console.WriteLine("############################################################");

                        //Title
                        if (Translate.Language == CurrentLanguage.Ru)
                            Console.WriteLine($"=== {obj.Title_Ru} ===");
                        if (Translate.Language == CurrentLanguage.En)
                            Console.WriteLine($"=== {obj.Title_En} ===");
                        else
                            Console.WriteLine($"=== {obj.Title_Az} ===");

                        //Content
                        if (Translate.Language == CurrentLanguage.Ru)
                            Console.WriteLine($"=== {obj.Content_Ru} ===");
                        if (Translate.Language == CurrentLanguage.En)
                            Console.WriteLine($"=== {obj.Content_En} ===");
                        else
                            Console.WriteLine($"=== {obj.Content_Az} ===");

                            int i = 1;
                        try
                        {
                            foreach (CommentConstructor item in DataContext.Comments)
                            {
                                if (item.CodeOfBlog == obj.Code)
                                {
                                    Console.WriteLine($"{i}.[{item.DateTime}] [{item.Owner.Name} {item.Owner.LastName}] - {item.Text}");
                                    i++;
                                }
                            }
                        }
                        catch
                        {
                            return;
                        }
                    }
                }
            }
            catch
            {
                return;
            }

           
        }
    }
}
