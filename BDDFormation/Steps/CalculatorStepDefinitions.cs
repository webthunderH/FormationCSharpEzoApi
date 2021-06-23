﻿using ApplicationCore;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace BDDFormation.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        private CalculatorTest calculatorTest = new CalculatorTest();

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            _scenarioContext["FirstNumber"]= number;

        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 
            _scenarioContext["SecondNumber"] = number;
            _scenarioContext.Pending();
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            //TODO: implement act (action) logic
            var firstNumber =(int)_scenarioContext["FirstNumber"];
            var secondNumber = (int)_scenarioContext["SecondNumber"];
            _scenarioContext["Result"] = calculatorTest.Add(firstNumber, secondNumber);
           
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic
            _scenarioContext["Result"].Should().Be((int)_scenarioContext["FirstNumber"] + (int)_scenarioContext["SecondNumber"]);
            _scenarioContext.Pending();
        }
    }
}
