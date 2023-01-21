using QualityLab.Support;

namespace QualityLab.PageObjects
{
    public abstract class AbstractPage
    {
        protected IWebDriver _driver;

        public AbstractPage()
        {
            _driver = SingleWebDriver.GetInstance();
            _driver.Manage().Window.Maximize();
        }

        public abstract void OpenThisPage();
    }
}
