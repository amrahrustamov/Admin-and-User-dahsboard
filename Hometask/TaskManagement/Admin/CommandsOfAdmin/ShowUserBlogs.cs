using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Database.Models;
using TaskManagement.Database;
using TaskManagement.Language.translator;
using TaskManagement.LanguageSystem;

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
                    Type t = typeof(Blog);
                    Console.WriteLine($"Blog ID : {blog.Id} | Blog status: {blog.Status} | Blog time of create : {DateTime.Now}");
                    Console.Write("Blog name : ");
                    Console.WriteLine(LangCurrentTitle(blog));
                    Console.Write("Blog : ");
                    Console.WriteLine(LangCurrentContent(blog));                     
                }
            }
        }    
        
        public static string LangCurrentTitle(Blog blog)
        {
           while(true)
            {
                if(CurrentLanguage.Az == Translate.Language)
                    return blog.Title_Az;

                if (CurrentLanguage.Ru == Translate.Language)
                    return blog.Title_Ru;

                if (CurrentLanguage.En == Translate.Language)
                    return blog.Title_En;

                return blog.Title_Az;
            }
        }
        public static string LangCurrentContent(Blog blog)
        {
            while (true)
            {
                if (CurrentLanguage.Az == Translate.Language)
                    return blog.Content_Az;

                if (CurrentLanguage.Ru == Translate.Language)
                    return blog.Content_Ru;

                if (CurrentLanguage.En == Translate.Language)
                    return blog.Content_En;

                return blog.Title_Az;
            }
        }
    }
}
