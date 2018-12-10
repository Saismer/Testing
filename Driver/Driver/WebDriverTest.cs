using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;

namespace Driver
{
    [TestFixture]
    class TestWebDriver
    {

        [Test]
        public void Main()
        {
            IWebDriver browser;
            browser = new OpenQA.Selenium.Chrome.ChromeDriver();
            browser.Manage().Window.Maximize();
            browser.Navigate().GoToUrl("https://www.anywayanyday.com/en/");

            IWebElement cityFrom = browser.FindElement(By.ClassName("awadWidget-aviaInput"));
            cityFrom.SendKeys("Moscow" + OpenQA.Selenium.Keys.Enter);
            System.Threading.Thread.Sleep(2000);

            IWebElement cityTo = browser.FindElement(By.XPath("//*[@id=\"sidebar\"]/div/div/div/div/div[2]/div[3]/div/div[2]/div/input"));
            cityTo.SendKeys("San Francisco" + OpenQA.Selenium.Keys.Enter);

            IWebElement date = browser.FindElement(By.XPath("//*[@id=\"sidebar\"]/div/div/div/div/div[2]/div[3]/div/div[4]/div/div[1]"));
            date.Click();
            System.Threading.Thread.Sleep(2000);

            IWebElement datePick = browser.FindElement(By.XPath("//*[@id=\"sidebar\"]/div/div/div/div/div[2]/div[3]/div/div[5]/div/div[2]/div[2]/table/tbody/tr[5]/td[4]/span"));
            datePick.Click();
            System.Threading.Thread.Sleep(2000);

            IWebElement returnFlight = browser.FindElement(By.XPath("//*[@id=\"sidebar\"]/div/div[1]/div/div/div[2]/div[4]/div[1]/div[1]"));
            returnFlight.Click();
            System.Threading.Thread.Sleep(2000);
            try
            {
                IWebElement datePickSecond = browser.FindElement(By.XPath("//*[@id=\"sidebar\"]/div/div[1]/div/div/div[2]/div[3]/div/div[5]/div/div[2]/div[2]/table/tbody/tr[5]/td[2]/span"));
                datePickSecond.Click();
                System.Threading.Thread.Sleep(2000);
                Assert.AreNotEqual(null, browser.FindElement(By.XPath("//*[@id=\"sidebar\"]/div/div[1]/div/div/div[2]/div[2]/ul/li[2]/div[1]/div[1]/div[1]/div[1]")));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

            IWebElement searchFlight = browser.FindElement(By.XPath("//*[@id=\"sidebar\"]/div/div/div/div/div[2]/div[4]/a"));
            searchFlight.Click();
            System.Threading.Thread.Sleep(2000);
        }
    }
}
