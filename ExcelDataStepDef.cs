using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowProject
{

    [Binding]
    class ExcelDataStepDef
    {

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(string p0)
        {
            Console.WriteLine("number entered");
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            Console.WriteLine("add pressed");
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(string p0)
        {
            Console.WriteLine("number displayed");
        }

    }
}
