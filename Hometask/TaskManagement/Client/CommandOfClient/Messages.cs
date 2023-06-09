﻿using TaskManagement.Database;
using TaskManagement.Database.Models;

namespace TaskManagement.Client.CommandOfClient
{
    public class Messages
    {
        public static void Handle(string email)
        {
           
            for (int i = 0; i < DataContext.Messages.Count; i++) //System.NullReferenceException: 'Object reference not set to an instance of an object.'
            {
                Inbox inbox = DataContext.Messages[i];

                if (inbox.Recipient == email)
                {
                    for (int j = 0; j < DataContext.Users.Count; j++)
                    {
                        User user = DataContext.Users[j];
                        int counter = 1;

                        if (user.Email == inbox.Sender)
                        {
                            Console.WriteLine($"{counter}.{user.Name} {user.LastName} {user.Email} | {inbox.Message}");
                            Console.WriteLine("");
                            counter++;
                        }
                    }
                }
            }
        }
    }
}
