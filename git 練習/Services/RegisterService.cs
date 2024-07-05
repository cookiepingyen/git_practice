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
                Console.WriteLine("帳號已存在，請重新輸入帳號");
                return false;
            }

            return InsertAccountToDB(model);
            
        }

        public bool InsertAccountToDB(UserModel model)
        {
            return true;
        }

        public bool SendEmail(string content)
        {   
            Console.WriteLine("發送驗證信");
            return true;
        }
    }
}