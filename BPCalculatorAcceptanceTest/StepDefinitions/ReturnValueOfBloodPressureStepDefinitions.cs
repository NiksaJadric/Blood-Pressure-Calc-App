using System;
using TechTalk.SpecFlow;

namespace BPCalculatorAcceptanceTest.StepDefinitions
{
    [Binding]
    public class ReturnValueOfBloodPressureStepDefinitions
    {
        [Given(@"Systolic Pressure is (.*) and Diastolic pressure is (.*)")]
        public void GivenSystolicPressureIsAndDiastolicPressureIs(int p0, int p1)
        {
        }

        [When(@"I click to calculate Blood Pressure")]
        public void WhenIClickToCalculateBloodPressure()
        {
        }

        [Then(@"response should be (.*)")]
        public void ThenResponseShouldBe(string p2)
        {
        }
    }
}
