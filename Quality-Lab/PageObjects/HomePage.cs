using QualityLab.Support;

namespace QualityLab.PageObjects
{
    public class HomePage: AbstractPage
    {
        private const string PageUrl = $"{Urls.Host}";
        public IWebElement ButtonEnter => _driver.FindElement(By.XPath($"//button[@data-testid='enter-mail-primary']"));
        public IWebElement TextBoxEnterAccountName => _driver.FindElement(By.XPath($"//input[@name='username']"));
        public IWebElement ButtonNextEnterPassword => _driver.FindElement(By.XPath($"//button[@data-test-id='next-button']"));
        public IWebElement TextBoxEnterPassword => _driver.FindElement(By.XPath($"//input[@name='password']"));
        public IWebElement ButtonSubmit => _driver.FindElement(By.XPath($"//button[@data-test-id='submit-button']"));
        public IWebElement Iframe => _driver.FindElement(By.XPath($"//iframe[@class='ag-popup__frame__layout__iframe']"));

        public HomePage()
        {
        }

        public override void OpenThisPage()
        {
            _driver.Navigate().GoToUrl(PageUrl);
        }

        public void EnterEmail(string email)
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.SwitchTo().Frame(Iframe);
            TextBoxEnterAccountName.SendKeys(email);
        }

        public void EnterPassword(string password)
        {
            TextBoxEnterPassword.SendKeys(password);
        }

        public void ClickOnButtonEnter()
        {
            ButtonEnter.Click();
        } 

        public void ClickOnButtonNextEnterPassword()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            ButtonNextEnterPassword.Click();
        }

        public void ClickOnButtonSubmit()
        {
            ButtonSubmit.Click();
        }

        public string GetCurrentUrl()
        {
            var url = _driver.Url;

           return url;
        }

    }
}
