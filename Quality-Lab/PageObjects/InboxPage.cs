using QualityLab.Support;

namespace QualityLab.PageObjects
{
    public class InboxPage : AbstractPage
    {
        private const string PageUrl = $"{Urls.Inbox}";
        public IWebElement LabelAccountName => _driver.FindElement(By.XPath($"//span[@class='ph-project__user-name svelte-1hiqrvn']"));
        public IWebElement ButtonWriteMessage => _driver.FindElement(By.XPath($"//span[@class='compose-button__wrapper']"));
        public IWebElement TextBoxAddressee => _driver.FindElement(By.XPath($"//input[@class='container--H9L5q size_s--3_M-_']"));
        public IWebElement ButtonCloseNotifications => _driver.FindElement(By.XPath($"//div[@class='ph-project-promo-close-icon__container svelte-m7oyyo']"));
        public IWebElement TextBoxMessage => _driver.FindElement(By.XPath($"//div[@tabindex='505']//child::div"));
        public IWebElement ButtonSendMessage => _driver.FindElement(By.XPath($"//button[@data-test-id='send']"));

        public InboxPage()
        {
        }

        public override void OpenThisPage()
        {
            _driver.Navigate().GoToUrl(PageUrl);
        }

        public string GetAccountName()
        {
            string accountName = _driver.FindElement(By.XPath($"//span[@class='ph-project__user-name svelte-1hiqrvn']")).Text;

            return accountName;
        }

        public void ClickOnButtonWriteMessage()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            ButtonWriteMessage.Click();
        }

        public void EnterAddressee(string addressee)
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            TextBoxAddressee.SendKeys(addressee);
        }

        public void CloseNotifications()
        {
            ButtonCloseNotifications.Click();
        }

        public void EnterMessage(string message)
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            TextBoxMessage.SendKeys(message);
        }

        public void ClickOnSendMessageButton()
        {
            ButtonSendMessage.Click();
        }

        public string GetLabelMessageSendText()
        {
            string labelMessageSendText = _driver.FindElement(By.XPath($"//div[@class='layer__header']")).Text;

            return labelMessageSendText;
        }
    }
}
