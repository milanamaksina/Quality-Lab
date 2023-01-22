namespace QualityLab.Support
{
    [Binding]
    public class Hooks
    {
        [AfterScenario]
        public void AfterScenario()
        {
            SingleWebDriver.CloseDriver();
        }
    }
}
