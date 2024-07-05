using git_練習.Models;
using git_練習.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git_練習
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            Console.ReadKey();

            LoginService loginService = new LoginService();

            UserModel user = new UserModel("yen", "aaa", "password", "taipei", "phone");

            loginService.IfAlreadyLogin(user);
            loginService.Login(user);
            loginService.TwoStepValidation(user);

        }


    }
}
