using Newtonsoft.Json;
using TaskManagement.Client.CommandOfClient;
using TaskManagement.Database.Models;

namespace TaskManagement.Database.DataJson
{
    public class DataOfJson
    {
        public static void JSonUserDocRamToFile()
        {
            var pathName = @"C:\DataOfCSharp\user.txt";
            File.WriteAllText(pathName, System.Text.Json.JsonSerializer.Serialize(DataContext.Users));
        }
        public static void JsonUserDocFileToRam()
        {
            var pathName = @"C:\DataOfCSharp\user.txt";
            var readText = File.ReadAllText(pathName);
            var output = JsonConvert.DeserializeObject<List<User>>(readText);
            DataContext.Users = output!;
        }
        public static void JSonMessageDocRamToFile()
        {
            var pathName = @"C:\DataOfCSharp\message.txt";
            File.WriteAllText(pathName, System.Text.Json.JsonSerializer.Serialize(DataContext.Messages));
        }
        public static void JsonMessageDocFileToRam()
        {
            var pathName = @"C:\DataOfCSharp\message.txt";
            var readText = File.ReadAllText(pathName);
            var output = JsonConvert.DeserializeObject<List<Inbox>>(readText);
            DataContext.Messages = output!;
        }
        public static void JSonBlogsDocRamToFile()
        {
            var pathName = @"C:\DataOfCSharp\blog.txt";
            File.WriteAllText(pathName, System.Text.Json.JsonSerializer.Serialize(DataContext.Blogs));
        }
        public static void JsonBlogsDocFileToRam()
        {
            var pathName = @"C:\DataOfCSharp\blog.txt";
            var readText = File.ReadAllText(pathName);
            var output = JsonConvert.DeserializeObject<List<Blog>>(readText);
            DataContext.Blogs = output!;
        }
        public static void JSonCommentDocRamToFile()
        {
            var pathName = @"C:\DataOfCSharp\comment.txt";
            File.WriteAllText(pathName, System.Text.Json.JsonSerializer.Serialize(DataContext.Comments));
        }
        public static void JsonCommentDocFileToRam()
        {
            var pathName = @"C:\DataOfCSharp\comment.txt";
            var readText = File.ReadAllText(pathName);
            var output = JsonConvert.DeserializeObject<List<Comments>>(readText);
            DataContext.Comments = output!;
        }
    }
}
