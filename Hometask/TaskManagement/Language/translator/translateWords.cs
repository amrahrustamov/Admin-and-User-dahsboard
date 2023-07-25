using Microsoft.VisualBasic;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Common;
using TaskManagement.LanguageSystem;

namespace TaskManagement.Language.translator
{
    public class translateWords
    {
        public static void LangChoise(string command)
        {

            
            if (Translate.Language == CurrentLanguage.Az)
            {
                switch (command)
                {
                    case "/qeydiyyat":
                        RegisterCommand.Handle();
                        break;
                    case "/giris":
                        LoginCommand.Handle();
                        break;
                    case "/serhlerle-bloqlari-goster":
                        BlogAndComment.Handle();
                        break;
                    case "/dil-secimlerinizi-yenileyin":
                        LocalizationService.Handle();
                        break;
                    case "/cixis":
                        LocalizationService.GetTranslation(TranslationKey.byeBye);
                        return;
                    default:
                        LocalizationService.GetTranslation(TranslationKey.invalidCommand);
                        break;
                }
            }
            if (Translate.Language == CurrentLanguage.Ru)
            {
                switch (command)
                {
                    case "/регистрация":
                        RegisterCommand.Handle();
                        break;
                    case "/вход":
                        LoginCommand.Handle();
                        break;
                    case "/показать-блоги-с-комментариями":
                        BlogAndComment.Handle();
                        break;
                    case "/обновить-языковые-настройки":
                        LocalizationService.Handle();
                        break;
                    case "/выход":
                        LocalizationService.GetTranslation(TranslationKey.byeBye);
                        return;
                    default:
                        LocalizationService.GetTranslation(TranslationKey.invalidCommand);
                        break;
                }
            }
            if (Translate.Language == CurrentLanguage.En)
            {
                switch (command)
                {
                    case "/register":
                        RegisterCommand.Handle();
                        break;
                    case "/login":
                        LoginCommand.Handle();
                        break;
                    case "/show-blogs-with-comments":
                        BlogAndComment.Handle();
                        break;
                    case "/update-language-preference":
                        LocalizationService.Handle();
                        break;
                    case "/exit":
                        Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.byeBye));
                        return;
                    default:
                        Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.invalidCommand));
                        
                        break;
                }
            }
        }
        public static void ShowMenu()
        {



            Console.WriteLine("");
            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.register));
            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.login));
            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.showBlogsWithComments));
            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.updateLanguage));
            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.exit));    
            Console.WriteLine("");
        }


        #region Main

        public const string addCommand_Az = "Komanda əlavə edin";
        public const string addCommand_Ru = "Добавить команду";
        public const string addCommand_En = "Add command";

        public const string register_Az = "/qeydiyyat";
        public const string register_Ru = "/регистрация";
        public const string register_En = "/register";

        public const string login_Az = "/giris";
        public const string login_Ru = "/вход";
        public const string login_En = "/login";

        public const string showBlogsWithComments_Az = "/serhlerle-bloqlari-goster";
        public const string showBlogsWithComments_Ru = "/показать-блоги-с-комментариями";
        public const string showBlogsWithComments_En = "/show-blogs-with-comments";

        public const string updateLanguage_Az = "/dil-secimlerinizi-yenileyin";
        public const string updateLanguage_Ru = "/обновить-языковые-настройки";
        public const string updateLanguage_En = "/update-language-preference";

        public const string exit_Az = "/cixis";
        public const string exit_Ru = "/выход";
        public const string exit_En = "/exit";

        public const string invalidCommand_Az = "Yanlis komanda, Yeniden daxil edin";
        public const string invalidCommand_Ru = "Неверная команда, пожалуйста, попробуйте еще раз";
        public const string invalidCommand_En = "Invalid command, pls try again";

        public const string byeBye_Az = "helelik";
        public const string byeBye_Ru = "пока";
        public const string byeBye_En = "bye bye";

        public const string addBlogNameAze_Az = "Azərbaycan dilində blogun başlığını əlavə et : ";
        public const string addBlogNameAze_Ru = "Добавить название блога на азербайджанском языке : ";
        public const string addBlogNameAze_En = "Add blog title in Azerbaijani : ";

        public const string addBlogNameRus_Az = "Rus dilində blog başlığını əlavə et : ";
        public const string addBlogNameRus_Ru = "Добавить название блога на русском языке : ";
        public const string addBlogNameRus_En = "Add blog title in Russian : ";

        public const string addBlogNameEng_Az = "İngilis dilində blog başlığını əlavə et : ";
        public const string addBlogNameEng_Ru = "Добавить название блога на английском языке : ";
        public const string addBlogNameEng_En = "Add blog title in English : ";

        public const string addBlogAze_Az = "Azərbaycan dilində blog məzmunu əlavə edin : ";
        public const string addBlogAze_Ru = "Добавить содержимое блога на азербайджанском языке : ";
        public const string addBlogAze_En = "Add blog content in Azerbaijani : ";

        public const string addBlogRus_Az = "Rus dilində blog məzmunu əlavə edin : ";
        public const string addBlogRus_Ru = "Добавить контент блога на русском языке : ";
        public const string addBlogRus_En = "Add blog content in Russian : ";

        public const string addBlogEng_Az = "İngilis dilində blog məzmunu əlavə edin : ";
        public const string addBlogEng_Ru = "Добавить контент блога на английском языке : ";
        public const string addBlogEng_En = "Add blog content in English : ";

        #endregion

        #region register

        public const string addName_Az = "Zəhmət olmasa ad daxil edin";
        public const string addName_Ru = "Пожалуйста, введите имя";
        public const string addName_En = "Pls enter first name";

        public const string someInfoIncorrect_Az = "Bəzi məlumatlar düzgün deyil";
        public const string someInfoIncorrect_Ru = "Некоторая информация неверна";
        public const string someInfoIncorrect_En = "Some information is not correct";

        public const string addLastName_Az = "Zəhmət olmasa soyadını daxil edin";
        public const string addLastName_Ru = "Пожалуйста, введите фамилию";
        public const string addLastName_En = "Pls enter last name";

        public const string addPassword_Az = "Zəhmət olmasa parol daxil edin";
        public const string addPassword_Ru = "Пожалуйста, введите пароль";
        public const string addPassword_En = "Pls enter password";

        public const string addRePassword_Az = "Zəhmət olmasa təsdiq parolunu daxil edin";
        public const string addRePassword_Ru = "Пожалуйста, введите пароль для подтверждения";
        public const string addRePassword_En = "Pls enter confirm password";

        public const string addEmail_Az = "Zəhmət olmasa e - poçtu daxil edin";
        public const string addEmail_Ru = "Пожалуйста, введите адрес электронной почты";
        public const string addEmail_En = "Pls enter email";

        public const string incorrectDomain_Az = "Yanlış daxiletmə! Bu proqramda yalnız code.edu.az domenindən istifadə olunur";
        public const string incorrectDomain_Ru = "Неверный ввод! В этом приложении используется только домен code.edu.az";
        public const string incorrectDomain_En = "Incorrect input!In this app used only domain of code.edu.az";

        public const string needAtSign_Az = "Yanlış daxiletmə! Girişinizdə bir @ işarəsi olmalıdır";
        public const string needAtSign_Ru = "Неверный ввод! В вашем вводе должен быть один знак @";
        public const string needAtSign_En = "Incorrect input! Must be one @ sign in your input";

        public const string allowLetterAndNumber_Az = "Yanlış daxiletmə! Yalnız (min 1) hərf və rəqəmlərə (min1) icazə verilir";
        public const string allowLetterAndNumber_Ru = "Неверный ввод! Разрешены только (мин. 1) буквы и цифры (мин. 1)";
        public const string allowLetterAndNumber_En = "Incorrect input! Only (min 1)letters and numbers(min1) are allowed";

        public const string textLengInfo_Az = "Yanlış daxiletmə! Mətnin uzunluğu minimum 10 ilə maksimum 30 simvol arasında olmalıdır";
        public const string textLengInfo_Ru = "Неверный ввод! Длина текста должна быть от 10 до 30 символов";
        public const string textLengInfo_En = "Incorrect input! Text length must be between min 10 and max 30 charachters";

        public const string existEmailInfo_Az = "Bu e-poçt artıq sistemdə istifadə olunur, lütfən, başqa e-poçtu yoxlayın";
        public const string existEmailInfo_Ru = "Этот адрес электронной почты уже используется в системе, попробуйте другой адрес электронной почты.";
        public const string existEmailInfo_En = "This email is already used in system, pls try another email";

        public const string succesRegistr_Az = "Siz uğurla qeydiyyatdan keçmisiniz";
        public const string succesRegistr_Ru = "Вы успешно зарегистрировались";
        public const string succesRegistr_En = "You have successfully registered";
        #endregion

        #region login

        public const string helloAdmin_Az = "Salam admin";
        public const string helloAdmin_Ru = "Привет админ";
        public const string helloAdmin_En = "Hello admin";

        public const string hello_Az = "Salam";
        public const string hello_Ru = "Salam";
        public const string hello_En = "Hello";

        public const string showUser_Az = "/istifadecileri-gösterin";
        public const string showUser_Ru = "/показать-пользователей";
        public const string showUser_En = "/show-users";

        public const string showUserByEmail_Az = "/istifadecini e-poct vasitesile gosterin";
        public const string showUserByEmail_Ru = "/показать-пользователя-по-электронной-почте";
        public const string showUserByEmail_En = "/show-user-by-email";

        public const string showUserById_Az = "/istifadecini-id-ile-goste";
        public const string showUserById_Ru = "/показать пользователя по id";
        public const string showUserById_En = "/show-user-by-id";

        public const string addUser_Az = "/istifadeci-elave-edin";
        public const string addUser_Ru = "/Добавить-пользователя";
        public const string addUser_En = "/add-user";

        public const string promoteToAdmin_Az = "/admin-edin";
        public const string promoteToAdmin_Ru = "/повысить-до-администратора";
        public const string promoteToAdmin_En = "/promote-to-admin";

        public const string depromoteToAdmin_Az = "/adminlikden-cixar";
        public const string depromoteToAdmin_Ru = "/деактивировать-от-администратора";
        public const string depromoteToAdmin_En = "/depromote-from-admin";

        public const string updateUserSetting_Az = "/istifadeci-parametrini-yenile";
        public const string updateUserSetting_Ru = "/обновить настройки пользователя";
        public const string updateUserSetting_En = "/update-user-setting";

        public const string removeUser_Az = "/istifadecini-silin";
        public const string removeUser_Ru = "/удалить-пользователя";
        public const string removeUser_En = "/remove-user";

        public const string banUser_Az = "/istifadecini-deaktiv-et";
        public const string banUser_Ru = "/забанить-пользователя";
        public const string banUser_En = "/ban-user";

        public const string sendMessageTo_Az = "/mesaj-gonderin";
        public const string sendMessageTo_Ru = "/Отправить сообщение";
        public const string sendMessageTo_En = "/message-to";

        public const string messages_Az = "/Mesajlar";
        public const string messages_Ru = "/Сообщения";
        public const string messages_En = "/Messages";

        public const string addBlog_Az = "/Blog-elave-et";
        public const string addBlog_Ru = "/Добавить блог";
        public const string addBlog_En = "/Add-Blog";

        public const string noticeBlogCreated_Az = "Blog ugurla yaradildi";
        public const string noticeBlogCreated_Ru = "Блог успешно создан";
        public const string noticeBlogCreated_En = "The blog was successfully created";

        public const string checkBlogs_Az = "/bloglari-yoxlayin";
        public const string checkBlogs_Ru = "/проверить блоги";
        public const string checkBlogs_En = "/check-blogs";

        public const string logout_Az = "/cixis";
        public const string logout_Ru = "/выйти";
        public const string logout_En = "/logout";

        public const string emailNotFound_Az = "E-poçt tapılmadı";
        public const string emailNotFound_Ru = "Электронная почта не найдена";
        public const string emailNotFound_En = "Email not found";

        public const string becomeAdminInfo_Az = "Bu e-poçtun sahibi admin oldu";
        public const string becomeAdminInfo_Ru = "Владелец этого письма стал администратором";
        public const string becomeAdminInfo_En = "The owner of this email has become an admin";

        public const string isAdminInfo_Az = "/Bu e-poçtun sahibi artıq admindir";
        public const string isAdminInfo_Ru = "/Владелец этого адреса электронной почты уже является администратором";
        public const string isAdminInfo_En = "/The owner of this email is already admin";

        public const string becomeUserInfo_Az = "Bu e-poçtun sahibi istifadəçi oldu";
        public const string becomeUserInfo_Ru = "Владелец этого письма стал пользователем";
        public const string becomeUserInfo_En = "The owner of this email has become user";

        public const string isUserInfo_Az = "Bu e-poçtun sahibi artıq istifadəçidir";
        public const string isUserInfo_Ru = "Владелец этого электронного письма уже является пользователем";
        public const string isUserInfo_En = "The owner of this email already is user";

        public const string closeAccount_Az = "/Hesabi-baglayin";
        public const string closeAccount_Ru = "/Закрыть аккаунт";
        public const string closeAccount_En = "/CloseAccount";

        public const string addComments_Az = "/serh-elave-e";
        public const string addComments_Ru = "/добавить комментарий";
        public const string addComments_En = "/add-comment";

        public const string addCodeOfBlog_Az = "Blogun kodunu daxil edin : ";
        public const string addCodeOfBlog_Ru = "Введите код блога : ";
        public const string addCodeOfBlog_En = "Enter the blog code : ";

        public const string addCommentTextToBlog_Az = "Mətn əlavə edin : ";
        public const string addCommentTextToBlog_Ru = "Добавить текст : ";
        public const string addCommentTextToBlog_En = "Add text : ";

        public const string succesAddComment_Az = "Şərh uğurla əlavə edildi";
        public const string succesAddComment_Ru = "Комментарий успешно добавлен";
        public const string succesAddComment_En = "Comment successfully added";

        public const string notFoundBlogByCode_Az = "Bu kodda heç bir vlog tapılmadı";
        public const string notFoundBlogByCode_Ru = "В этом коде видеоблог не найден";
        public const string notFoundBlogByCode_En = "No vlog found in this code";

        public const string unsuccesCommentNotice_Az = "Mətnin uzunluğu 1 ilə 30 arasında olmalıdır və mətndə təhqiredici sözlərdən istifadə edilməməlidir.";
        public const string unsuccesCommentNotice_Ru = "Длина текста должна быть от 1 до 30, в тексте не должно быть оскорбительных слов";
        public const string unsuccesCommentNotice_En = "The length of the text must be between 1 and 30 and the text must not use offensive words";

        #endregion
    }
}
