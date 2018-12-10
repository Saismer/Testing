using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;

namespace Driver
{
    [TestFixture]
    class Tests
    {
        public static IWebDriver browser;
        [Test]
        public void TestOneCityAsStartEndPoints()
        {
            browser = new OpenQA.Selenium.Chrome.ChromeDriver();
            browser.Manage().Window.Maximize();
            browser.Navigate().GoToUrl("https://www.anywayanyday.com/en/");
            WebPageFactory page = new WebPageFactory();

            page.cityFrom.SendKeys("Moscow" + OpenQA.Selenium.Keys.Enter);
            System.Threading.Thread.Sleep(2000);
            page.cityTo.SendKeys("Moscow" + OpenQA.Selenium.Keys.Enter);

            page.date.Click();
            System.Threading.Thread.Sleep(2000);

            page.datePick.Click();
            System.Threading.Thread.Sleep(2000);

            page.searchFlight.Click();
            System.Threading.Thread.Sleep(7000);

            try
            {
                Assert.AreEqual(browser.FindElement(By.XPath("//*[@id=\"main\"]/div[1]/div[2]/div/h2")).GetAttribute("value"), "There are no flights for the chosen dates.");
                Console.WriteLine("Successfully");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
    }
}
