using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Database.Models
{
    public class CommentConstructor
    {
        public CommentConstructor(string text, string codeOfBlog, User owner, DateTime dateTime)
        {
            Text = text;
            CodeOfBlog = codeOfBlog;
            Owner = owner;
            DateTime = dateTime;
        }
        public string Text { get; set; }
        public string CodeOfBlog { get; set; }
        public User Owner { get; set; }
        public DateTime DateTime { get; set; }
    }
}
