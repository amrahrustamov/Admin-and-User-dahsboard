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
                    case "/şərhlərlə-bloqları-göstər":
                        BlogAndComment.Handle();
                        break;
                    case "/dil-secimlerinizi-yenileyin":
                        LocalizationService.Handle();
                        break;
                    case "/cixis":
                        ByeBye();
                        return;
                    default:
                        InvalidCommand();
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
                        ByeBye();
                        return;
                    default:
                        InvalidCommand();
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
                        ByeBye();
                        return;
                    default:
                        InvalidCommand();
                        break;
                }
            }
        }
        public static void ShowMenu()
        {
            Console.WriteLine("");
            Register();
            Login();
            ShowBlogsWithComments();
            UpdateLanguage();
            Exit();
            Console.WriteLine("");
        }
        public static void Common(string az, string ru, string en)
        {
            if (Translate.Language == CurrentLanguage.Az)
                Console.WriteLine(az);
            if (Translate.Language == CurrentLanguage.Ru)
                Console.WriteLine(ru);
            if (Translate.Language == CurrentLanguage.En)
                Console.WriteLine(en);
        }

        #region Main
        public static void AddCommand()
        {
            string az = "Komanda əlavə edin";
            string ru = "Добавить команду";
            string en = "Add command";
            Common(az, ru, en);
        }
        public  static void Register()
        {
            string az = "/qeydiyyat";
            string ru = "/регистрация";
            string en = "/register";
            Common(az, ru, en);
        }
        public static void Login()
        {
            string az = "/giris";
            string ru = "/вход";
            string en = "/login";
            Common(az, ru, en);
        }
        public static void ShowBlogsWithComments()
        {
            string az = "/şərhlərlə-bloqları-göstər";
            string ru = "/показать-блоги-с-комментариями";
            string en = "/show-blogs-with-comments";
            Common(az, ru, en);
        }
        public static void UpdateLanguage()
        {
            string az = "/dil-secimlerinizi-yenileyin";
            string ru = "/обновить-языковые-настройки";
            string en = "/update-language-preference";
            Common(az, ru, en);
        }
        public static void Exit()
        {
            string az = "/cixis";
            string ru = "/выход";
            string en = "/exit";
            Common(az, ru, en);
        }
        public static void InvalidCommand()
        {
            string az = "Yanlis komanda, Yeniden daxil edin";
            string ru = "Неверная команда, пожалуйста, попробуйте еще раз";
            string en = "Invalid command, pls try again";
            Common(az, ru, en);
        }
        public static void ByeBye()
        {
            string az = "helelik";
            string ru = "пока";
            string en = "bye bye";
            Common(az, ru, en);
        }
        public static void AddBlogNameAze()
        {
            string az = "Azərbaycan dilində blogun başlığını əlavə et : ";
            string ru = "Добавить название блога на азербайджанском языке : ";
            string en = "Add blog title in Azerbaijani : ";
            Common(az, ru, en);
        }
        public static void AddBlogNameRus()
        {
            string az = "Rus dilində blog başlığını əlavə et : ";
            string ru = "Добавить название блога на русском языке : ";
            string en = "Add blog title in Russian : ";
            Common(az, ru, en);
        }
        public static void AddBlogNameEng()
        {
            string az = "İngilis dilində blog başlığını əlavə et : ";
            string ru = "Добавить название блога на английском языке : ";
            string en = "Add blog title in English : ";
            Common(az, ru, en);
        }
        public static void AddBlogAze()
        {
            string az = "Azərbaycan dilində blog məzmunu əlavə edin : ";
            string ru = "Добавить содержимое блога на азербайджанском языке : ";
            string en = "Add blog content in Azerbaijani : ";
            Common(az, ru, en);
        }
        public static void AddBlogRus()
        {
            string az = "Rus dilində blog məzmunu əlavə edin : ";
            string ru = "Добавить контент блога на русском языке : ";
            string en = "Add blog content in Russian : ";
            Common(az, ru, en);
        }
        public static void AddBlogEng()
        {
            string az = "İngilis dilində blog məzmunu əlavə edin : ";
            string ru = "Добавить контент блога на английском языке : ";
            string en = "Add blog content in English : ";
            Common(az, ru, en);
        }
        #endregion

        #region register

        public static void AddName()
        {
            string az = "Zəhmət olmasa ad daxil edin";
            string ru = "Пожалуйста, введите имя";
            string en = "Pls enter first name";
            Common(az, ru, en);
        }
        public static void SomeInfoIncorrect()
        {
            string az = "Bəzi məlumatlar düzgün deyil";
            string ru = "Некоторая информация неверна";
            string en = "Some information is not correct";
            Common(az, ru, en);
        }
        public static void AddLastName()
        {
            string az = "Zəhmət olmasa soyadını daxil edin";
            string ru = "Пожалуйста, введите фамилию";
            string en = "Pls enter last name";
            Common(az, ru, en);
        }
        public static void AddPassword()
        {
            string az = "Zəhmət olmasa parol daxil edin";
            string ru = "Пожалуйста, введите пароль";
            string en = "Pls enter password";
            Common(az, ru, en);
        }
        public static void AddRePassword()
        {
            string az = "Zəhmət olmasa təsdiq parolunu daxil edin";
            string ru = "Пожалуйста, введите пароль для подтверждения";
            string en = "Pls enter confirm password";
            Common(az, ru, en);
        }
        public static void AddEmail()
        {
            string az = "Zəhmət olmasa e - poçtu daxil edin";
            string ru = "Пожалуйста, введите адрес электронной почты";
            string en = "Pls enter email";
            Common(az, ru, en);
        }
        public static void IncorrectDomain()
        {
            string az = "Yanlış daxiletmə! Bu proqramda yalnız code.edu.az domenindən istifadə olunur";
            string ru = "Неверный ввод! В этом приложении используется только домен code.edu.az";
            string en = "Incorrect input!In this app used only domain of code.edu.az";
            Common(az, ru, en);
        }
        public static void NeedAtSign()
        {
            string az = "Yanlış daxiletmə! Girişinizdə bir @ işarəsi olmalıdır";
            string ru = "Неверный ввод! В вашем вводе должен быть один знак @";
            string en = "Incorrect input! Must be one @ sign in your input";
            Common(az, ru, en);
        }
        public static void AllowLetterAndNumber()
        {
            string az = "Yanlış daxiletmə! Yalnız (min 1) hərf və rəqəmlərə (min1) icazə verilir";
            string ru = "Неверный ввод! Разрешены только (мин. 1) буквы и цифры (мин. 1)";
            string en = "Incorrect input! Only (min 1)letters and numbers(min1) are allowed";
            Common(az, ru, en);
        }
        public static void TextLengInfo()
        {
            string az = "Yanlış daxiletmə! Mətnin uzunluğu minimum 10 ilə maksimum 30 simvol arasında olmalıdır";
            string ru = "Неверный ввод! Длина текста должна быть от 10 до 30 символов";
            string en = "Incorrect input! Text length must be between min 10 and max 30 charachters";
            Common(az, ru, en);
        }
        public static void ExistEmailInfo()
        {
            string az = "Bu e-poçt artıq sistemdə istifadə olunur, lütfən, başqa e-poçtu yoxlayın";
            string ru = "Этот адрес электронной почты уже используется в системе, попробуйте другой адрес электронной почты.";
            string en = "This email is already used in system, pls try another email";
            Common(az, ru, en);
        }
        public static void SuccesRegistr()
        {
            string az = "Siz uğurla qeydiyyatdan keçmisiniz";
            string ru = "Вы успешно зарегистрировались";
            string en = "You have successfully registered";
            Common(az, ru, en);
        }
        #endregion

        #region login
        public static void HelloAdmin()
        {
            string az = "Salam admin";
            string ru = "Привет админ";
            string en = "Hello admin";
            Common(az, ru, en);
        }
        public static void Hello()
        {
            string az = "Salam";
            string ru = "Привет";
            string en = "Hello";
            Common(az, ru, en);
        }
        public static void ShowUser()
        {
            string az = "/istifadəçiləri-göstərin";
            string ru = "/показать-пользователей";
            string en = "/show-users";
            Common(az, ru, en);
        }
        public static void ShowUserByEmail()
        {
            string az = "/istifadəçini e-poçt vasitəsilə göstərin";
            string ru = "/показать-пользователя-по-электронной-почте";
            string en = "/show-user-by-email";
            Common(az, ru, en);
        }
        public static void ShowUserById()
        {
            string az = "/istifadəçini-id-ilə-göstər";
            string ru = "/показать пользователя по id";
            string en = "/show-user-by-id";
            Common(az, ru, en);
        }
        public static void AddUser()
        {
            string az = "/istifadeci-elave-edin";
            string ru = "/Добавить-пользователя";
            string en = "/add-user";
            Common(az, ru, en);
        }
        public static void PromoteToAdmin()
        {
            string az = "/admin-edin";
            string ru = "/повысить-до-администратора";
            string en = "/promote-to-admin";
            Common(az, ru, en);
        }
        public static void DepromoteToAdmin()
        {
            string az = "/adminlikden-cixar";
            string ru = "/деактивировать-от-администратора";
            string en = "/depromote-from-admin";
            Common(az, ru, en);
        }
        public static void UpdateUserSetting()
        {
            string az = "/istifadəçi-parametrini-yenile";
            string ru = "/обновить настройки пользователя";
            string en = "/update-user-setting";
            Common(az, ru, en);
        }
        public static void RemoveUser()
        {
            string az = "/istifadecini-silin";
            string ru = "/удалить-пользователя";
            string en = "/remove-user";
            Common(az, ru, en);
        }
        public static void BanUser()
        {
            string az = "/istifadəçini-deaktiv-et";
            string ru = "/забанить-пользователя";
            string en = "/ban-user";
            Common(az, ru, en);
        }
        public static void SendMessageTo()
        {
            string az = "/mesaj-göndərin";
            string ru = "/Отправить сообщение";
            string en = "/message-to";
            Common(az, ru, en);
        }
        public static void Messages()
        {
            string az = "/Mesajlar";
            string ru = "/Сообщения";
            string en = "/Messages";
            Common(az, ru, en);
        }
        public static void AddBlog()
        {
            string az = "/Blog-elave-et";
            string ru = "/Добавить блог";
            string en = "/Add-Blog";
            Common(az, ru, en);
        }
        public static void CheckBlogs()
        {
            string az = "/blogları-yoxlayın";
            string ru = "/проверить блоги";
            string en = "/check-blogs";
            Common(az, ru, en);
        }
        public static void Logout()
        {
            string az = "/cixis";
            string ru = "/выйти";
            string en = "/logout";
            Common(az, ru, en);
        }
        public static void EmailNotFound()
        {
            string az = "E-poçt tapılmadı";
            string ru = "Электронная почта не найдена";
            string en = "Email not found";
            Common(az, ru, en);
        }
        public static void BecomeAdminInfo()
        {
            string az = "Bu e-poçtun sahibi admin oldu";
            string ru = "Владелец этого письма стал администратором";
            string en = "The owner of this email has become an admin";
            Common(az, ru, en);
        }
        public static void IsAdminInfo()
        {
            string az = "Bu e-poçtun sahibi artıq admindir";
            string ru = "Владелец этого адреса электронной почты уже является администратором";
            string en = "The owner of this email is already admin";
            Common(az, ru, en);
        }
        public static void BecomeUserInfo()
        {
            string az = "Bu e-poçtun sahibi istifadəçi oldu";
            string ru = "Владелец этого письма стал пользователем";
            string en = "The owner of this email has become user";
            Common(az, ru, en);
        }
        public static void IsUserInfo()
        {
            string az = "Bu e-poçtun sahibi artıq istifadəçidir";
            string ru = "Владелец этого электронного письма уже является пользователем";
            string en = "The owner of this email already is user";
            Common(az, ru, en);
        }
        public static void CloseAccount()
        {
            string az = "/Hesabi-baglayin";
            string ru = "/Закрыть аккаунт";
            string en = "/CloseAccount";
            Common(az, ru, en);
        }
        public static void AddComments()
        {
            string az = "/şərh əlavə et";
            string ru = "/добавить комментарий";
            string en = "/add-comment";
            Common(az, ru, en);
        }
        public static void AddCodeOfBlog()
        {
            string az = "Blogun kodunu daxil edin : ";
            string ru = "Введите код блога : ";
            string en = "Enter the blog code : ";
            Common(az, ru, en);
        }
        public static void AddCommentTextToBlog()
        {
            string az = "Mətn əlavə edin : ";
            string ru = "Добавить текст : ";
            string en = "Add text : ";
            Common(az, ru, en);
        }

        //translateWords.IsUserInfo();
        #endregion

        #region Extra

        //public static List<TranslationContainer> _translations = new List<TranslationContainer>
        //{
        //     new TranslationContainer("AddCommand","Komanda əlavə edin","Добавить команду","Add command"),
        //     new TranslationContainer("Register","/qeydiyyat","/регистрация","/register"),
        //     new TranslationContainer("Login","/giris","/вход","/login"),
        //     new TranslationContainer("UpdateLanguage","/dil-secimlerinizi-yenileyin","/обновить-языковые-настройки","/update-language-preference"),
        //     new TranslationContainer("Exit","/cixis","/выход","/exit"),
        //     new TranslationContainer("InvalidCommand","Yanlis komanda, Yeniden daxil edin","Неверная команда, пожалуйста, попробуйте еще раз","Invalid command, pls try again"),
        //     new TranslationContainer("ByeBye","helelik","пока","bye bye"),
        //     new TranslationContainer("AddName","Zəhmət olmasa ad daxil edin","Пожалуйста, введите имя","Pls enter first name"),
        //     new TranslationContainer("SomeInfoIncorrect","Bəzi məlumatlar düzgün deyil","Некоторая информация неверна","Some information is not correct"),
        //     new TranslationContainer("AddLastName","Zəhmət olmasa soyadını daxil edin","Пожалуйста, введите фамилию","Pls enter last name"),
        //     new TranslationContainer("AddPassword","Zəhmət olmasa parol daxil edin","Пожалуйста, введите пароль","Pls enter password"),
        //     new TranslationContainer("AddRePassword","Zəhmət olmasa təsdiq parolunu daxil edin","Пожалуйста, введите пароль для подтверждения","Pls enter confirm password"),
        //     new TranslationContainer("AddEmail","Zəhmət olmasa e - poçtu daxil edin","Пожалуйста, введите адрес электронной почты","Pls enter email"),
        //     new TranslationContainer("IncorrectDomain","Yanlış daxiletmə! Bu proqramda yalnız code.edu.az domenindən istifadə olunur","Неверный ввод! В этом приложении используется только домен code.edu.az","Incorrect input!In this app used only domain of code.edu.az"),
        //     new TranslationContainer("NeedAtSign","Yanlış daxiletmə! Girişinizdə bir @ işarəsi olmalıdır","Неверный ввод! В вашем вводе должен быть один знак @","Incorrect input! Must be one @ sign in your input"),
        //     new TranslationContainer("AllowLetterAndNumber","Yanlış daxiletmə! Yalnız (min 1) hərf və rəqəmlərə (min1) icazə verilir","Неверный ввод! Разрешены только (мин. 1) буквы и цифры (мин. 1)","Incorrect input! Only (min 1)letters and numbers(min1) are allowed"),
        //     new TranslationContainer("TextLengInfo","Yanlış daxiletmə! Mətnin uzunluğu minimum 10 ilə maksimum 30 simvol arasında olmalıdır","Неверный ввод! Длина текста должна быть от 10 до 30 символов","Incorrect input! Text length must be between min 10 and max 30 charachters"),
        //     new TranslationContainer("ExistEmailInfo","Bu e-poçt artıq sistemdə istifadə olunur, lütfən, başqa e-poçtu yoxlayın","Этот адрес электронной почты уже используется в системе, попробуйте другой адрес электронной почты.","This email is already used in system, pls try another email"),
        //     new TranslationContainer("SuccesRegistr","Siz uğurla qeydiyyatdan keçmisiniz","Вы успешно зарегистрировались","You have successfully registered"),
        //     new TranslationContainer("ShowUser","/istifadəçiləri-göstərin","/показать-пользователей","/show-users"),
        //     new TranslationContainer("ShowUserByEmail","/istifadəçini e-poçt vasitəsilə göstərin","/показать-пользователя-по-электронной-почте","/show-user-by-email"),
        //     new TranslationContainer("ShowUserById","/istifadəçini-id-ilə-göstər","/показать пользователя по id","/show-user-by-id"),
        //     new TranslationContainer("AddUser","/istifadeci-elave-edin","/Добавить-пользователя","/add-user"),
        //     new TranslationContainer("PromoteToAdmin","/admin-edin","/повысить-до-администратора","/promote-to-admin"),
        //     new TranslationContainer("DepromoteToAdmin","/adminlikden-cixar","/деактивировать-от-администратора","/depromote-from-admin"),
        //     new TranslationContainer("UpdateUserSetting","/istifadəçi-parametrini-yenile","/обновить настройки пользователя","/update-user-setting"),
        //     new TranslationContainer("RemoveUser","/istifadecini-silin","/удалить-пользователя","/remove-user"),
        //     new TranslationContainer("BanUser","/istifadəçini-deaktiv-et","/забанить-пользователя","/ban-user"),
        //     new TranslationContainer("SendMessageTo","/mesaj-göndərin","/Отправить сообщение","/message-to"),
        //     new TranslationContainer("CheckBlogs","/blogları-yoxlayın","/проверить блоги","/check-blogs"),
        //     new TranslationContainer("Logout","/cixis","/выйти","/logout"),
        //     new TranslationContainer("EmailNotFound","E-poçt tapılmadı","Электронная почта не найдена","Email not found"),
        //     new TranslationContainer("BecomeAdminInfo","Bu e-poçtun sahibi admin oldu","покаВладелец этого письма стал администратором","The owner of this email has become an admin"),
        //     new TranslationContainer("IsAdminInfo","Bu e-poçtun sahibi artıq admindir","Владелец этого адреса электронной почты уже является администратором","The owner of this email is already admin"),
        //     new TranslationContainer("BecomeUserInfo","Bu e-poçtun sahibi istifadəçi oldu","Владелец этого письма стал пользователем","The owner of this email has become user"),
        //     new TranslationContainer("IsUserInfo","Bu e-poçtun sahibi artıq istifadəçidir","Владелец этого электронного письма уже является пользователем","The owner of this email already is user"),
        //};


        #endregion
    }
}
