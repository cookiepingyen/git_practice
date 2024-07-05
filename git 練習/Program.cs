using git_練習.Models;
using git_練習.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using git_練習.Models;
using git_練習.Services;

namespace git_練習
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 註冊模組
            Console.WriteLine("歡迎使用者登入我們的GIT系統，請先輸入註冊訊息，以利後續登入做使用");
            while (true)
            {
                string name = Console.ReadLine();
                string email = Console.ReadLine();
                string account = Console.ReadLine();
                string password = Console.ReadLine();
                string phone = Console.ReadLine();
                UserModel registerModel = new UserModel(name, email, account, password,phone);
                RegisterService service = new RegisterService();
                bool isSuccess = service.Regist(registerModel);

                if (isSuccess)
                {
                    Console.WriteLine("註冊成功！");
                    break;
                }
                else
                {
                    Console.WriteLine("註冊失敗！請重新註冊！");
                }
            }
            #endregion

            Console.ReadKey();

            LoginService loginService = new LoginService();

            UserModel user = new UserModel("yen", "aaa", "password", "taipei", "phone");

            loginService.IfAlreadyLogin(user);
            loginService.Login(user);
            loginService.TwoStepValidation(user);

        }


    }
}
