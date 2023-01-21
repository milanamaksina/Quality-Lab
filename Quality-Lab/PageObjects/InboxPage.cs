using QualityLab.Support;

namespace QualityLab.PageObjects
{
    public class InboxPage : AbstractPage
    {
        private const string PageUrl = $"{Urls.Inbox}";
        public IWebElement LabelAccountName => _driver.FindElement(By.XPath($"//span[@class='ph-project__user-name svelte-1hiqrvn']"));

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


    }
}
