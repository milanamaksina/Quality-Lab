using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using QualityLab.Support;

namespace QualityLab.PageObjects
{
    public class HomePage: AbstractPage
    {
        private const string PageUrl = $"{Urls.Host}";
        public IWebElement ButtonEnter => _driver.FindElement(By.XPath($"//button[@data-testid='enter-mail-primary']"));
        public IWebElement TextBoxEnterAccountName => _driver.FindElement(By.XPath($"//*[@id=\"root\"]/div/div/div/div[2]/div/div/form/div[2]/div[2]/div[1]/div/div/div/div/div/div[1]"));
        public IWebElement ButtonNextEnterPassword => _driver.FindElement(By.XPath($"//button[@data-test-id=[@'next-button']"));
        public IWebElement TextBoxEnterPassword => _driver.FindElement(By.XPath($"//input[@name='password']"));
        public IWebElement ButtonSubmit => _driver.FindElement(By.XPath($"//input[data-test-id=[@'submit-button']]"));

        public HomePage()
        {
        }

        public override void OpenThisPage()
        {
            _driver.Navigate().GoToUrl(PageUrl);
        }

        public void EnterEmail(string email)
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
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
            ButtonNextEnterPassword.Click();
        }

        public void ClickOnButtonSubmit()
        {
            ButtonSubmit.Click();
        }

    }
}
