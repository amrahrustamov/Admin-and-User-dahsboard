﻿using TaskManagement.Admin.Commands;
using TaskManagement.Client.CommandOfClient;
using TaskManagement.Common;
using TaskManagement.Database.Models;
using TaskManagement.Language.translator;
using TaskManagement.LanguageSystem;

namespace TaskManagement.Admin
{
    public class AdminDashboard
    {
        public static void Introduction(User user)
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.helloAdmin));
            Console.WriteLine($" : {user.Name} {user.LastName}");
            Console.WriteLine("");

            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.showUser));
                Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.showUserByEmail));
                Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.showUserById));
                Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.addUser));
                Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.promoteToAdmin));
                Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.depromoteToAdmin));
                Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.updateUserSetting));
                Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.removeUser));
                Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.banUser));
                Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.sendMessageTo));
                Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.checkBlogs));
                Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.logout));
                Console.WriteLine("");

                Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.addCommand));
                string command = Console.ReadLine()!;
               
                if (Translate.Language == CurrentLanguage.Az)
                {
                    switch (command)
                    {
                       case "/istifadecileri-gösterin":
                           ShowUsersCommand.Handle();
                           break;
                       case "/istifadecini e-poct vasitesile gosterin":
                           ShowUserByEmailCommand.Handle();
                           break;
                       case "/istifadecini-id-ile-goster":
                           ShowUserByIdCommand.Handle();
                           break;
                       case "/istifadeci-elave-edin":
                           AddUserCommand.Handle();
                           break;
                       case "/admin-edin":
                           PromoteToAdminCommand.Handle();
                           break;
                       case "/adminlikden-cixar":
                           DepromoteFromAdminCommand.Handle();
                           break;
                       case "/istifadeci-parametrini-yenile":
                           AddUpdateSettingCommand.Handle(user);
                           break;
                       case "/istifadecini-silin":
                           RemoveUserByEmail.Handle();
                           break;
                       case "/istifadecini-deaktiv-et":
                           BanUserCommand.Handle();
                           break;
                       case "/bloglari-yoxlayin":
                           CheckBlogsCommand.Handle();
                           break;
                       case "/mesaj-gonderin":
                           MessageToCommand.Handle(user);
                           break;
                       case "/cixis":
                            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.byeBye));
                            return;
                       default:
                            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.invalidCommand));
                            break;
                    }
                }
                if (Translate.Language == CurrentLanguage.Ru)
                {
                    switch (command)
                    {
                        case "/показать-пользователей":
                            ShowUsersCommand.Handle();
                            break;
                        case "/показать-пользователя-по-электронной-почте":
                            ShowUserByEmailCommand.Handle();
                            break;
                        case "/показать пользователя по id":
                            ShowUserByIdCommand.Handle();
                            break;
                        case "/Добавить-пользователя":
                            AddUserCommand.Handle();
                            break;
                        case "/повысить-до-администратора":
                            PromoteToAdminCommand.Handle();
                            break;
                        case "/деактивировать-от-администратора":
                            DepromoteFromAdminCommand.Handle();
                            break;
                        case "/обновить настройки пользователя":
                            AddUpdateSettingCommand.Handle(user);
                            break;
                        case "/удалить-пользователя":
                            RemoveUserByEmail.Handle();
                            break;
                        case "/забанить-пользователя":
                            BanUserCommand.Handle();
                            break;
                        case "/проверить блоги":
                            CheckBlogsCommand.Handle();
                            break;
                        case "/Отправить сообщение":
                            MessageToCommand.Handle(user);
                            break;
                        case "/выйти":
                            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.byeBye));
                            return;
                        default:
                            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.invalidCommand));
                            break;
                    }
                }
                if (Translate.Language == CurrentLanguage.En)
                {
                    switch (command)
                    {
                        case "/show-users":
                            ShowUsersCommand.Handle();
                            break;
                        case "/show-user-by-email":
                            ShowUserByEmailCommand.Handle();
                            break;
                        case "/show-user-by-id":
                            ShowUserByIdCommand.Handle();
                            break;
                        case "/add-user":
                            AddUserCommand.Handle();
                            break;
                        case "/promote-to-admin":
                            PromoteToAdminCommand.Handle();
                            break;
                        case "/depromote-from-admin":
                            DepromoteFromAdminCommand.Handle();
                            break;
                        case "/update-user-setting":
                            AddUpdateSettingCommand.Handle(user);
                            break;
                        case "/remove-user":
                            RemoveUserByEmail.Handle();
                            break;
                        case "/ban-user":
                            BanUserCommand.Handle();
                            break;
                        case "/check-blogs":
                            CheckBlogsCommand.Handle();
                            break;
                        case "/message-to":
                            MessageToCommand.Handle(user);
                            break;
                        case "/logout":
                            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.byeBye));
                            return;
                        default:
                            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.invalidCommand));
                            break;
                    }
                }
            }
        }
    }
}
