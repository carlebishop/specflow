using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace giving_tests
{
    [Binding]
    internal class ScenarioBeforeAndAfter
    {
        [BeforeScenario]
        public static void Before()
        {
            // runs before each scenario and scenario outline in example
        }

        [AfterScenario]
        public static void After()
        {
            
        }
}
}
