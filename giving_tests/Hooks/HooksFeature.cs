using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace giving_tests
{
    [Binding]
    public sealed class HooksFeature
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeFeature]
        public static void BeforeFeature()
        {
            
      
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            var t = FeatureContext.Current.FeatureInfo.Description;  // gets current feature description
        }
    }
}
