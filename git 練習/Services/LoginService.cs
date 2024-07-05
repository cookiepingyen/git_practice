using git_練習.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git_練習.Services
{
    public class LoginService
    {
        public bool Login(UserModel model)
        {
            return true;
        }

        public bool TwoStepValidation(UserModel model)
        {
            Console.WriteLine("發送二階段認證");
            return true;
        }

        public void Notice(UserModel user)
        {
            if (TwoStepValidation(user) == true)
            {
                Console.WriteLine("登入成功");
            }
        }

        public bool IfAlreadyLogin(UserModel user)
        {
            return true;
        }

        public void Logout(UserModel user)
        {
            Console.WriteLine("Logout");
        }
    }
}
