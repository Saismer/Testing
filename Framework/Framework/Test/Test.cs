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
        private Steps.Steps steps = new Steps.Steps();
        private const string oneCityInitialAndEnd = "There are no flights for the chosen dates.";
        private const string complexFlightSeacrhing = "complex flight";
        private const double currencyExchange = 75.50;

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

        //Test #1 from test-cases
        [Test]
        public void ReturnFlightWithWrongDate()
        {
            steps.OpenPage();
            steps.FillDataForSearching("Moscow","San Francisco");
            steps.FillDate("normal");
            Assert.AreNotEqual(null, steps.AddReturnDate());
        }
        
        //Test #2 from test-cases
        [Test]
        public void OneCityAsInitialAndEndPoint()
        {
            steps.OpenPage();
            steps.FillDataForSearching("Moscow", "Moscow");
            steps.FillDate("normal");
            Assert.AreEqual(oneCityInitialAndEnd, steps.SearchFlight("bad flight"));
        } 

        //Test #3 from test-cases
        [Test]
        public void CheckNumberOfAdultMoreThanSix()
        {
            steps.OpenPage();
            steps.OpenListOfPersons();
            Assert.AreEqual(false, steps.AddAdults());
        }

        //Test #4 from test-cases
        [Test]
        public void CheckMoreThanOneBabyForOneAdult()
        {
            steps.OpenPage();
            steps.OpenListOfPersons();
            Assert.AreEqual(false, steps.AddBaby());
        }

        //Test #5 from test-cases
        [Test]
        public void CheckNumberOfAdultLessThenOne()
        {
            steps.OpenPage();
            steps.OpenListOfPersons();
            Assert.AreEqual(false, steps.DeleteAdults());
        }


        //Test #6 from test-cases
        [Test]
        public void CheckComplexRoute()
        {
            steps.OpenPage();
            steps.FillDataForSearching("Moscow", "Kiev");
            steps.FillDate("normal");
            steps.ComplexFlight();
            steps.FillDataForComplexSearching("Moscow", "San Francisco");
            steps.FillDate("complex");
            Assert.AreEqual(complexFlightSeacrhing, steps.SearchFlight("complex"));
        }

        //Test #7 from test-cases
        [Test]
        public void CheckEarlyDateForFlight()
        {
            steps.OpenPage();
            steps.FillDataForSearching("Moscow", "San Francisco");
            Assert.AreEqual(false, steps.FillDate("early"));
        }

        //Test #8 from test-cases
        [Test]
        public void CheckMaxNumberOfPersons()
        {
            steps.OpenPage();
            steps.OpenListOfPersons();
            Assert.AreEqual(false, steps.AddPersons());
        }

        //Test #9 from test-cases
        [Test]
        public void FilterFlightsWithConnection()
        {
            steps.OpenPage();
            steps.FillDataForSearching("Moscow", "Kiev");
            steps.FillDate("normal");
            steps.SearchFlight();
            Assert.AreEqual(true, steps.FilterResultsOfFlights());
        }

        //Test #10 from test-cases
        [Test]
        public void CheckCalculation()
        {
            steps.OpenPage();
            steps.FillDataForSearching("Moscow", "Kiev");
            steps.FillDate("normal");
            steps.SearchFlight();
            steps.ChangeCurrency();
            Assert.AreEqual(false, steps.Calculate(currencyExchange));
        }
    }
}
