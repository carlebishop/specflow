using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giving_tests
{
    public class Test1Steps
    {
        private GivingLoginPage givingPage;

        public Test1Steps(GivingLoginPage givingPage)
        {
            this.givingPage = givingPage;
        }

        public string Runem()
        {

            givingPage.NavToPage();
            givingPage.LogIn();
            return "Ok";
        }
    }
}
