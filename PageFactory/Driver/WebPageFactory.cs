using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Driver
{
    class WebPageFactory
    {
        public WebPageFactory()
        {
            PageFactory.InitElements(Tests.browser, this);
        }

        [FindsBy(How = How.ClassName, Using = "awadWidget-aviaInput")]
        public IWebElement cityFrom;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"sidebar\"]/div/div/div/div/div[2]/div[3]/div/div[2]/div/input")]    
        public IWebElement cityTo;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"sidebar\"]/div/div/div/div/div[2]/div[3]/div/div[4]/div/div[1]")]
        public IWebElement date;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"sidebar\"]/div/div/div/div/div[2]/div[3]/div/div[5]/div/div[2]/div[2]/table/tbody/tr[5]/td[3]/span")]
        public IWebElement datePick;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"sidebar\"]/div/div/div/div/div[2]/div[4]/a")]
        public IWebElement searchFlight;
    }
}
