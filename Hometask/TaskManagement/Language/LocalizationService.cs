﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Common;
using TaskManagement.Database.Models;
using TaskManagement.Language.translator;
using TaskManagement.Utilities;

namespace TaskManagement.LanguageSystem
{
    public class LocalizationService
    {

        public static void Handle()
        {
            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("/Az");
                Console.WriteLine("/Ru");
                Console.WriteLine("/En");
                Console.WriteLine("");

                Console.Write("Add command : ");
                string command = Console.ReadLine()!;

                switch (command)
                {
                    case "/Az":
                        Translate.Language = CurrentLanguage.Az;
                        return;
                    case "/Ru":
                        Translate.Language = CurrentLanguage.Ru;
                        return;
                    case "/En":
                        Translate.Language = CurrentLanguage.En;
                        return;
                    default:
                        Console.WriteLine("Invalid command, pls try again");
                        break;
                }
            }
        }
    }
}
