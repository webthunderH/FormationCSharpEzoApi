using ApplicationCore.UtilisateurDomaine;
using TechTalk.SpecFlow;
using Moq;
using ApplicationCore;
using FluentAssertions;

namespace SpecFlowProjectFormation.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly CalculatorTest calculator;
        private int result;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            calculator = new CalculatorTest();
         }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
          
            _scenarioContext["PremierNombre"] = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            
            _scenarioContext["DeuxiemeNombre"] = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
           
            result = calculator.AddTwoInt((int)_scenarioContext["PremierNombre"], (int)_scenarioContext["DeuxiemeNombre"]);
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            
            var variable1 = (int)_scenarioContext["PremierNombre"];
            var variable2 = (int)_scenarioContext["DeuxiemeNombre"];
            result.Should().Be(variable1 + variable2);
        }
    }
}
