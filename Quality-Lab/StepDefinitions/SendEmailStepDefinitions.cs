using QualityLab.PageObjects;
using QualityLab.Support;

namespace QualityLab.StepDefinitions
{
    [Binding]
    public class SendEmailStepDefinitions
    {
        private InboxPage _inboxPage;

        public SendEmailStepDefinitions()
        {
            _inboxPage = new InboxPage();
        }

        [Given(@"I open mail\.ru inbox page")]
        public void GivenIOpenMail_RuInboxPage()
        {
            _inboxPage.OpenThisPage();
        }

        [Given(@"click on button write message")]
        public void GivenClickOnButtonWriteMessage()
        {
            try
            {
              _inboxPage.CloseNotifications();
            }
            finally
            {
              _inboxPage.ClickOnButtonWriteMessage();
            }
        }

        [When(@"I enter the addressee ""([^""]*)""")]
        public void WhenIEnterTheAddressee(string addressee)
        {
           _inboxPage.EnterAddressee(addressee);
        }

        [When(@"write a message ""([^""]*)""")]
        public void WhenWriteAMessage(string message)
        {
            _inboxPage.EnterMessage(message);
        }

        [When(@"click on send button")]
        public void WhenClickOnSendButton()
        {
            _inboxPage.ClickOnSendMessageButton();
        }

        [Then(@"I can see the notification with text ""([^""]*)""")]
        public void ThenICanSeeTheNotificationWithText(string expectedText)
        {
            var actualMessage = _inboxPage.GetLabelMessageSendText();

            Assert.Equal(expectedText, actualMessage);
            //SingleWebDriver.CloseDriver();
        }

    }
}
