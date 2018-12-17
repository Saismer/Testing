using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages
{
    class ResultPage
    {
        private IWebDriver driver;

        [FindsBy(How = How.ClassName, Using = "offersAirlines-switchOption")]
        private IWebElement sortFlights;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main\"]/div/div[1]/div[2]/div[2]/div[2]/span[2]/span[1]")]
        private IWebElement numberFound;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main\"]/div/div[1]/div[2]/div[2]/div[2]/span[2]/span[2]")]
        private IWebElement numberAll;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main\"]/div/div[2]/div[1]/div[1]/div/div[1]/div[2]/div[2]/div[1]/a/span/span[1]")]
        private IWebElement currencyValue;

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div/div[1]/div/div[2]/div/span")]
        private IWebElement chooseCurrency;

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div/div[1]/div/div[2]/div/div/ul/li[3]")]
        private IWebElement euroCurrency;
        
        public ResultPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void FilterFlights()
        {
            sortFlights.Click();
        }

        public bool CheckFilterFlights()
        {
            if (Int32.Parse(numberFound.Text.ToString()) <= Int32.Parse(numberAll.Text.ToString()))
            {
                return true;
            }
            else
                return false;
        }

        public void ChangeCurrency()
        {
            chooseCurrency.Click();
            euroCurrency.Click();
        }

        public string GetCurrencyValue()
        {
            string result = currencyValue.Text.ToString();
            result = result.Replace(" ", string.Empty);
            return result;
        }

    }
}
