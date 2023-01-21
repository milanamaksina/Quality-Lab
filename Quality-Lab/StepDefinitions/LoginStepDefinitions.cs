using OpenQA.Selenium.Support.UI;
using QualityLab.PageObjects;
using QualityLab.Support;

namespace QualityLab.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        private HomePage _homePage;

        public LoginStepDefinitions()
        {
            _homePage = new HomePage();
        }

        [Given(@"registered user")]
        public void GivenRegisteredUser()
        {
           //Preconditions registration
        }

        [When(@"click on enter button")]
        public void WhenClickOnEnterButton()
        {
            _homePage.ClickOnButtonEnter();
        }

        [When(@"enter email ""([^""]*)""")]
        public void WhenEnterEmail(string email)
        {
            _homePage.EnterEmail(email);
        }

        [When(@"enter password ""([^""]*)""")]
        public void WhenEnterPassword(string password)
        {
            throw new PendingStepException();
        }

        [Then(@"inbox page should opened")]
        public void ThenInboxPageShouldOpened()
        {
            throw new PendingStepException();
        }

        [Then(@"user name must be ""([^""]*)""")]
        public void ThenUserNameMustBe(string p0)
        {
            throw new PendingStepException();
        }
    }
}
