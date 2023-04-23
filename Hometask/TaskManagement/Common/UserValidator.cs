﻿using TaskManagement.Database;
using TaskManagement.Database.Models;
using TaskManagement.Utilities;

namespace TaskManagement.Common
{
    public class UserValidator
    {
        private StringUtility _utility = new StringUtility();

        #region First name
        public string GetAndValidateFirstName()
        {
            while (true)
            {
                Console.WriteLine("Pls enter first name : ");
                string firstName = Console.ReadLine()!;

                if (IsValidFirstName(firstName))
                    return firstName;

                Console.WriteLine("Some information is not correnct");
            }
        }
        private bool IsValidFirstName(string firstName)
        {
            int MIN_LENGTH = 3;
            int MAX_LENGTH = 30;

            return IsValidName(firstName, MIN_LENGTH, MAX_LENGTH);
        }
        #endregion

        #region Last name
        public string GetAndValidateLastName()
        {
            while (true)
            {
                Console.WriteLine("Pls enter last name : ");
                string lastName = Console.ReadLine()!;

                if (IsValidLastName(lastName))
                    return lastName;

                Console.WriteLine("Some information is not correnct");
            }
        }
        private bool IsValidLastName(string lastName)
        {
            int MIN_LENGTH = 5;
            int MAX_LENGTH = 20;

            return IsValidName(lastName, MIN_LENGTH, MAX_LENGTH);
        }

        #endregion

        #region Password
        public string GetAndValidatePassword()
        {
            while (true)
            {
                Console.WriteLine("Pls enter password : ");
                string password = Console.ReadLine()!;

                Console.WriteLine("Pls enter confirm password : ");
                string confirmPassword = Console.ReadLine()!;

                if (password == confirmPassword)
                    return password;

                Console.WriteLine("Some information is not correnct");
            }
        }
        #endregion

        #region Email
        public string SendMessageByEmail()
        {
             while(true)
             {
                  Console.WriteLine("Pls enter email : ");
                  string email = Console.ReadLine()!;
                  
                  if (IsEmailExists(email))
                   return email;

                  else
                  {
                      Console.WriteLine("This email is not valid! Try again");
                  }               
             }        
        }
        public string GetAndValidateEmail()
        {
            while (true)
            {
                Console.WriteLine("Pls enter email : ");
                string email = Console.ReadLine()!;

                if(CheckDomain(email) && CheckSeparator(email) && CheckReceipent(email) && CheckEmailLength(email))
                {
                    if (!IsEmailExists(email))
                    return email;
                    else
                        Console.WriteLine("Your email is already used in system, pls try another email");
                }                          
            }
        }
        public bool CheckDomain(string email)
        {
            string domainPattern = "^@code.edu.az\b";
            if (email == domainPattern)
                return true;
            return false;          
        }
        public bool CheckSeparator(string email)
        {
            string seperatorPattern = "(@)code.edu.az";
            if(email == seperatorPattern)
                return true;
            return false;
        }
        public bool CheckReceipent(string email)
        {
            string pattern = @"\w+@";
            while (true)
            {
                if (email == pattern)
                    return true;
                return false;              
            }
        }
        public bool CheckEmailLength(string email)
        {
            int i = 0;
            while(true)  ///find length
            {
                char atSign = '@';
                if (email[i] != atSign)
                    i++;
                else
                    break;
            }
                       ///control length
            if (i >= 10 && i <= 30)
                return true;
            else
                return false;
        }
        private bool IsEmailExists(string email)
        {
            foreach (User user in DataContext.Users)
            {
                if (User.Email == email)
                    return true;
            }
            return false;
        }
        #endregion

        #region Message

        public string CheckMessage()
        {
            while(true)
            {
                try
                {
                    Console.WriteLine("Add message : ");
                    string message = Console.ReadLine()!;

                    if(message.Length > 1 && message.Length < 51)
                    return message;
                }
                catch
                {
                    Console.WriteLine("Incorrect! Pls add between 2 and 50 characters");
                }
            }           
        }

        #endregion

        #region Common
        private bool IsValidName(string name, int minLength, int maxLenght)
        {
            if (!_utility.IsLengthBetween(name, minLength, maxLenght))
                return false;

            char firstLetter = name[0];

            if (!_utility.IsUpperLetter(firstLetter))
                return false;

            for (int i = 1; i < name.Length; i++)
            {
                if (_utility.IsUpperLetter(name[i]))
                    return false;
            }
            return true;
        }
        #endregion
    }
}
