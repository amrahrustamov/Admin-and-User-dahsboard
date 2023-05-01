using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Database;
using TaskManagement.Language.translator;

namespace TaskManagement.LanguageSystem
{
    public class Translate
    {
        public static CurrentLanguage Language { get; set; }
        public Translate(CurrentLanguage language) 
        {
            Language = language;
        }
    }
}

