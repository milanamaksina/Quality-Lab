namespace QualityLab.Support
{
    public class Hooks
    {

        [AfterScenario]
        public void AfterScenario()
        {
            SingleWebDriver.CloseDriver();
        }
    }
}
