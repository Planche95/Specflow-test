using FluentAssertions;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;

namespace SpecflowTest.Steps
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        private List<int> values = new List<int>();
        private int result;

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int value)
        {
            values.Add(value);
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            result = values.Sum();
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int value)
        {
            result.Should().Be(value);
        }
    }
}
