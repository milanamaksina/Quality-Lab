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

        [Given(@"I open mail\.ru home page")]
        public void WhenOpenMail_RuHomePage()
        {
            var driver = SingleWebDriver.GetInstance();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(Urls.Host);
        }

        [Given(@"click on enter button")]
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

        [When(@"click on submit button")]
        public void WhenClickOnSubmitButton()
        {
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

        [Then(@"label account name is ""([^""]*)""")]
        public void ThenLabelAccountNameMustBe(string expectedName)
        {
            string actualName = _inboxPage.GetAccountName();
            Assert.Equal(expectedName, actualName);
        }
    }
}
