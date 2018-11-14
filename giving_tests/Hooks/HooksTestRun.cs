using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace giving_tests
{
    [Binding]
    public sealed class HooksTestRun
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            
        }
    }
}
