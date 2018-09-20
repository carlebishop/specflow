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
        private DashboardPage dashboardPage; 

        public Test1Steps(GivingLoginPage givingPage)
        {
            this.givingPage = givingPage;
            dashboardPage = new DashboardPage();
        }

        public bool Runem()
        {
            bool rc = true;

            givingPage.NavToPage();
            if (givingPage.LogIn())
            {
                rc = true;
            }
            else
            {
                rc = false;
            }

            dashboardPage.CheckforOrganizationElement();



            return rc;
        }
    }
}
