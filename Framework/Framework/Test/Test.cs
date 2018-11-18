using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Framework.Test
{
    [TestFixture]
    class Test
    {
        public Steps.Steps steps = new Steps.Steps();
        public const string errorMess = "The amount of adult can't be more than 6";

        [SetUp]
        public void Init()
        {
            steps.InitBrowser();
        }

        [TearDown]
        public void Cleanup()
        {
            steps.CloseBrowser();
        }

        //Test #3 from test-cases
        [Test]
        public void ErrorMessWhenMoreThanOneBabyForOneAdult()
        {
            steps.OpenPage();
            steps.OpenListOfPersons();
            Assert.AreEqual(errorMess, steps.AddAdults());
        }
    }
}
