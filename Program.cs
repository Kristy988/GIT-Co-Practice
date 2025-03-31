using Co_Practice.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Co_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            WelcomeAOV();
            AOVDescription();
            bool result = false;
            while (!result)
            {
                string username = Console.ReadLine();
                string password = Console.ReadLine();
                LoginService loginService = new LoginService(username, password);
                result = loginService.Login(username, password);
                if (!result)
                {
                    Console.WriteLine("請重新輸入帳號密碼");
                }
                else
                {
                    Console.WriteLine("登入成功");
                    break;
                }
            }

        }

        public static void WelcomeAOV()
        {
            Console.WriteLine("Welcome AOV World");
        }
        public static void AOVDescription()
        {
            Console.WriteLine("用心做造型 用腳做平衡");
            Console.WriteLine("TIMI Bye~");
        }

    }
}
