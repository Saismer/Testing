using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Driver
{
    class Program
    {
        public static IWebDriver browser;

        static void Main(string[] args)
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
            System.Threading.Thread.Sleep(2000);      
                 
            page.editMode.Click();
            System.Threading.Thread.Sleep(2000);

            page.edit.Click();
            System.Threading.Thread.Sleep(2000);

            page.cityFrom.Clear();
            page.cityFrom.SendKeys("Minsk");
            page.focus.Click();
            System.Threading.Thread.Sleep(2000);

            page.searchRightFlight.Click();
            System.Threading.Thread.Sleep(20000);
            browser.Quit();
        }
    }
}
