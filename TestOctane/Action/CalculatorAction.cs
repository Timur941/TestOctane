using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace TestOctane.Action
{
    [Binding]
    class CalculatorAction
    {
        [StepDefinition(@"успешный тест")]
        public void SuccessfullTest()
        {
            Assert.IsTrue(true);
        }

        [StepDefinition(@"упавший тест")]
        public void FailedTest()
        {
            Assert.IsTrue(false);
        }
    }
}
