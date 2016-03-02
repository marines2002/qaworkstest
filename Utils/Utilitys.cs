using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QaWorksTest.Models;
using QaWorksTest.PageModels;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace QaWorksTest.Utils
{
    public static class Utilitys
    {
        public static void SendContactMessage(Table table)
        {
            var contactPage = new QaWorksContactPage();

            var messageDetails = table.CreateInstance<MessageDetails>();

            contactPage.SendMessage(messageDetails.name, messageDetails.email, messageDetails.message);
        }
    }
}
