using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace giving_tests
{
    [Binding]
    internal class HooksScenario
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            var t = ScenarioContext.Current.ScenarioInfo.Title;
            var x = FeatureContext.Current.FeatureInfo.Description;
        }

        [AfterScenario]
        public void AfterScenario()
        {
            
        }
}
}
