using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Database.Models
{
    public class Blog
    {

        public static int IdCounter { get; private set; }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Title_Az { get; set; }
        public string Title_Ru { get; set; }
        public string Title_En { get; set; }
        public string Content_Az { get; set; }
        public string Content_Ru { get; set; }
        public string Content_En { get; set; }
        public User Owner { get; set; }
        public DateTime CreatedAt { get; set; }
        public BlogStatus Status { get; set; }
       

        public Blog(string code, string title_Az, string title_Ru, string title_En,
            string content_Az, string content_Ru, string content_En, User owner, BlogStatus status)
        {
            Code = code;
            Title_Az = title_Az;
            Title_Ru = title_Ru;
            Title_En = title_En;
            Content_Az = content_Az;
            Content_Ru = content_Ru;
            Content_En = content_En;
            Owner = owner;
            CreatedAt = DateTime.Now;
            Status = status;


        }
        
    }
}
