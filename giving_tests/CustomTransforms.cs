using System;
using System.Collections;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace giving_tests
{
    [Binding]
    public class CustomTransforms
    {
        [StepArgumentTransformation]
        public IEnumerable<NewUser> NewUsersTransform(Table table)
        {
            return table.CreateSet<NewUser>();
        }
    }
}
