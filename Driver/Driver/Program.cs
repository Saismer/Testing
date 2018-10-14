using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver browser;
            browser = new OpenQA.Selenium.Chrome.ChromeDriver();
            browser.Manage().Window.Maximize();
            browser.Navigate().GoToUrl("https://www.anywayanyday.com/en/");

            IWebElement cityFrom = browser.FindElement(By.ClassName("awadWidget-aviaInput"));
            cityFrom.SendKeys("Moscow" + OpenQA.Selenium.Keys.Enter);
            System.Threading.Thread.Sleep(2000);

            IWebElement cityTo = browser.FindElement(By.XPath("//*[@id=\"sidebar\"]/div/div/div/div/div[2]/div[3]/div/div[2]/div/input"));
            cityTo.SendKeys("Moscow" + OpenQA.Selenium.Keys.Enter);

            IWebElement date = browser.FindElement(By.XPath("//*[@id=\"sidebar\"]/div/div/div/div/div[2]/div[3]/div/div[4]/div/div[1]"));
            date.Click();
            System.Threading.Thread.Sleep(2000);

            IWebElement datePick = browser.FindElement(By.XPath("//*[@id=\"sidebar\"]/div/div/div/div/div[2]/div[3]/div/div[5]/div/div[2]/div[1]/table/tbody/tr[5]/td[3]/span"));
            datePick.Click();
            System.Threading.Thread.Sleep(2000);

            IWebElement searchFlight = browser.FindElement(By.XPath("//*[@id=\"sidebar\"]/div/div/div/div/div[2]/div[4]/a"));
            searchFlight.Click();
            System.Threading.Thread.Sleep(2000);      
                 
            IWebElement editMode = browser.FindElement(By.XPath("//*[@id=\"sidebar\"]/div/div/div/div/div[2]/div[2]/ul/li/div[1]/div[1]/div[2]"));
            editMode.Click();
            System.Threading.Thread.Sleep(2000);

            IWebElement edit = browser.FindElement(By.XPath("//*[@id=\"sidebar\"]/div/div/div/div/div[2]/div[2]/ul/li/div[1]/div[2]/div[1]"));
            edit.Click();
            System.Threading.Thread.Sleep(2000);

            cityFrom.Clear();
            cityFrom.SendKeys("Minsk");
            cityTo.Click();
            System.Threading.Thread.Sleep(2000);

            IWebElement searchRightFlight = browser.FindElement(By.XPath("//*[@id=\"sidebar\"]/div/div/div/div/div[2]/div[4]/a"));
            searchRightFlight.Click();
            System.Threading.Thread.Sleep(20000);
            browser.Quit();
        }
    }
}
