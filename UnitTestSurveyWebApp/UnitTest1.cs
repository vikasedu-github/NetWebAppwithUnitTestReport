using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using surveyWebAppwithTestCase;

namespace UnitTestSurveyWebApp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DemoClass obj = new DemoClass();
            Assert.AreEqual("Vikas",obj.fname);
            Assert.AreEqual("Mishra", obj.lname);
        }
    }
}
