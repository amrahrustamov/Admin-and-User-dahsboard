using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Database.Models;
using TaskManagement.Database;
using TaskManagement.Client;
using TaskManagement.Database.DataJson;

namespace TaskManagement.Admin.Commands
{
    public class AproveBlogs
    {
         public static void Handle()
         {
             Console.Write("Add blog's id for approve : ");
             int id = int.Parse(Console.ReadLine()!);  
            
            foreach(Blog userBlogs in DataContext.Blogs)
            {
                if(userBlogs.Id == id)
                {
                    userBlogs.Status = BlogStatus.Approved;
                    DataOfJson.JSonBlogsDocRamToFile();
                    return;
                }
            }
         }      
    }   
}
