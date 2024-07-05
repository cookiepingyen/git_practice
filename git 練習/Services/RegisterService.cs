using System;
using System.Runtime.ConstrainedExecution;
using System.Xml;
using git_練習.Models;

namespace git_練習.Services
{
    public class RegisterService
    {
        public bool Regist(UserModel model)
        {
            if (model.Email.Equals("leo604leo604@gmail.com"))
            {
                return true;
            }
            return false;
        }

        public bool SendEmail(string content)
        {   
            Console.WriteLine("發送驗證信");
            return true;
        }
    }
}