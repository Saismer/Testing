using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Framework.Pages
{
    class MainPage
    {
        public const string BASE_URL = "https://www.anywayanyday.com/";
        public IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"sidebar\"]/div/div[1]/div/div/div[2]/div[4]/div[2]/div[1]/div[3]")]
        public IWebElement listOfPersons;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"sidebar\"]/div/div[1]/div/div/div[2]/div[4]/div[2]/ul[1]/li[1]/div[1]")]
        public IWebElement plusAdult;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"sidebar\"]/div/div[1]/div/div/div[2]/div[4]/div[2]/ul[1]/li[1]/div[3]/span[1]")]
        public IWebElement summaryPersons;

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
        }

        public void OpenList()
        {
            listOfPersons.Click();
        }

        public void AddNewPerson()
        {
            plusAdult.Click();
        }
    }
}
