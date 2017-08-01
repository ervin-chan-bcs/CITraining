using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;

namespace CITraining.NUnitTests.StepDefinitions
{
    [Binding]
    public class AddTwoNumbersSteps
    {
        public List<int> numbers;
        public int answer;

        [BeforeScenario]
        public void Initialize()
        {
            numbers = new List<int>();
        }

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            numbers.Add(p0);
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            answer = numbers[0] + numbers[1];
        }

        [When(@"I press subtract")]
        public void WhenIPressSubtract()
        {
            answer = numbers[0] - numbers[1];
        }

        [When(@"I press multiply")]
        public void WhenIPressMultiply()
        {
            answer = numbers[0] * numbers[1];
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.IsTrue(p0 == answer);
        }
    }
}
