using QualityLab.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityLab.StepDefinitions
{
    [Binding]
    public class CommonSteps
    {
        [When(@"open mail\.ru home page")]
        public void WhenOpenMail_RuHomePage()
        {
            var driver = SingleWebDriver.GetInstance();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(Urls.Host);
        }
    }
}
