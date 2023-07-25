using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Common;
using TaskManagement.Database;
using TaskManagement.Database.Models;
using TaskManagement.Language.translator;
using TaskManagement.Database.DataJson;
using TaskManagement.LanguageSystem;

namespace TaskManagement.Client.CommandOfClient
{
    public class AddBlog
    {
        public static void Handle(User user)
        {
            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.addBlogNameAze));
            string title_Az = Console.ReadLine()!;
            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.addBlogNameRus));
            string title_Ru = Console.ReadLine()!;
            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.addBlogNameEng));
            string title_En = Console.ReadLine()!;

            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.addBlogAze));
            string content_Az = Console.ReadLine()!;
            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.addBlogRus));
            string content_Ru = Console.ReadLine()!;
            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.addBlogEng));
            string content_En = Console.ReadLine()!;

            string code = RandomCode();

            Blog blog = new Blog(code, title_Az, title_Ru, title_En, content_Az, content_Ru, content_En, user, BlogStatus.Created);
            DataContext.Blogs.Add(blog);          
            DataOfJson.JSonBlogsDocRamToFile();
            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.noticeBlogCreated));
        }
        public static string RandomCode()
        {
            //Blog-a random kod teyin etmek ucun
            Random rnd = new Random();

            int testCode = rnd.Next(10000, 100000);
            string code = $"BL{testCode}";

            DataContext.Blogs = new List<Blog>();

            foreach (Blog blog  in DataContext.Blogs)
            {
                if(blog.Code == code)
                   RandomCode();
            }           
              return code;
        }
    }
}
