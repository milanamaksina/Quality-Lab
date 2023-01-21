using QualityLab.Support;

namespace QualityLab.PageObjects
{
    public class AbstractPage
    {
        protected IWebDriver _driver;

        public AbstractPage()
        {
            _driver = SingleWebDriver.GetInstance();
            _driver.Manage().Window.Maximize();
        }
    }
}
