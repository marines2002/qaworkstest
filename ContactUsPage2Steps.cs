using System;
using QaWorksTest.Models;
using QaWorksTest.PageModels;
using QaWorksTest.Utils;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace QaWorksTest
{
    [Binding]
    public class ContactUsPage2Steps
    {
        [Given]
        public void Given_I_am_on_the_QAWorks_Staging_Site()
        {
            var homepage = new QaWorksHomePage();
            homepage.MainMenuContactItem.Click();
        }
        
        [Then]
        public void Then_I_should_be_able_to_contact_QAWorks_with_the_following_information(Table table)
        {
            Utilitys.SendContactMessage(table);

            // Assert message sent ok possible issue as no message is displayed
        }

        [When(@"I Send message with invalid email")]
        public void WhenISendMessageWithInvalidEmail(Table table)
        {
            Utilitys.SendContactMessage(table);
        }

        [Then(@"Invalid email error message is displayed")]
        public void ThenInvalidEmailErrorMessageIsDisplayed()
        {
            // Assert invalid email message pops up briefly then unhandled excpetion error page displays
            // The specified string is not in the form required for an e-mail address.
            // Dev's need to handle this error 

            // note could use Scenario Outline here to test multiple invalid emails
        }
        
       
    }
}
