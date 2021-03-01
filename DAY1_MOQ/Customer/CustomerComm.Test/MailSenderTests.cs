using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using CustomerCommLib;



namespace CustomerCommTest
{
    [TestFixture]
    public class MailSenderTests
    {
        CustomerComm customer;
        Mock<IMailSender> mockMailSender;
       [OneTimeSetUp]
        public void init()
        {
            mockMailSender = new Mock<IMailSender>();
            mockMailSender.Setup(m => m.SendMail(It.IsAny<string>(), It.IsAny<string>())).Returns(true);
            customer = new CustomerComm(mockMailSender.Object);
        }


        [TestCase("string1","string2")]
        [TestCase("foo", "bar")]
        [TestCase("spam", "eggs")]
        //[TestCase(1, "string2")]
        public void SendMailTest(string s1,string s2)
        {
            bool result = customer.SendMailToCustomer();
            //mockMailSender.Verify(m => m.SendMail(s1,s2));
            mockMailSender.Verify(m => m.SendMail(It.IsAny<string>(),It.IsAny<string>()));
            //bool result = mockMailSender.Object.SendMail(s1, s2);
            Assert.AreEqual(true, result);

        }
    }
}
