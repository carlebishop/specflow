using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using giving_tests;

namespace RunTests
{
    class Program
    {
        static void Main(string[] args)
        {
            GivingLoginPage startPage = new GivingLoginPage();
            Console.WriteLine("Initialized Page " + startPage.ToString());
            Test1Steps steps = new Test1Steps(startPage);
            steps.Runem();
        }
    }
}
