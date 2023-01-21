using OpenQA.Selenium.Support.UI;
using QualityLab.PageObjects;
using QualityLab.Support;

namespace QualityLab.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        private HomePage _homePage;
        private InboxPage _inboxPage;

        public LoginStepDefinitions()
        {
            _homePage = new HomePage();
            _inboxPage = new InboxPage();
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
            _homePage.ClickOnButtonNextEnterPassword();
        }

        [When(@"enter password ""([^""]*)""")]
        public void WhenEnterPassword(string password)
        {
            _homePage.EnterPassword(password);
            _homePage.ClickOnButtonSubmit();
        }

        [Then(@"can open inbox page")]
        public void ThenCanOpenInboxPage()
        {
            _inboxPage.OpenThisPage();
            string expectedUrl = $"{Urls.Inbox}";
            string actualUrl = SingleWebDriver.GetInstance().Url;
            Assert.Contains(expectedUrl, actualUrl);
        }

        [Then(@"label account name must be ""([^""]*)""")]
        public void ThenLabelAccountNameMustBe(string expectedName)
        {
            string actualName = _inboxPage.GetAccountName();
            Assert.Equal(expectedName, actualName);
        }
    }
}
