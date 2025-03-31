using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Co_Practice.Services
{
    internal class LoginService
    {
        public LoginService(string username, string password)
        {
            while (username == null)
            {
                Console.WriteLine();
            }
            while (password == null)
            {
                Console.WriteLine();
            }
            while (username == null)
            {
                Console.WriteLine();
            }
            while (username == null)
            {
                Console.WriteLine();
            }
        }
        public void Login(string username, string password)
        {
            if (username == password)
            {
                Console.WriteLine("登入成功");
            }
            else
            {
                Console.WriteLine("登入失敗");
            }
        }
    }
}
