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
        private const string BASE_URL = "https://www.anywayanyday.com/en/";
        private IWebDriver driver;

        [FindsBy(How = How.ClassName, Using = "awadWidget-aviaInput")]
        private IWebElement cityFrom;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"sidebar\"]/div/div/div/div/div[2]/div[3]/div/div[2]/div/input")]
        private IWebElement cityTo;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"sidebar\"]/div/div[1]/div/div/div[2]/div[4]/div[1]/div[2]")]
        private IWebElement complexFlight;
        
        [FindsBy(How = How.XPath, Using = "//*[@id=\"sidebar\"]/div/div[1]/div/div/div[2]/div[3]/div/div[1]/div/input")]
        private IWebElement cityComplexFrom;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"sidebar\"]/div/div[1]/div/div/div[2]/div[3]/div/div[2]/div/input")]
        private IWebElement cityComplexTo;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"sidebar\"]/div/div/div/div/div[2]/div[3]/div/div[4]/div/div[1]")]
        private IWebElement date;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"sidebar\"]/div/div[1]/div/div/div[2]/div[3]/div/div[4]/div")]
        private IWebElement dateComplex;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"sidebar\"]/div/div[1]/div/div/div[2]/div[3]/div/div[5]/div/div[2]/div[2]/table/tbody/tr[5]/td[3]/span")]
        private IWebElement datePick;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"sidebar\"]/div/div[1]/div/div/div[2]/div[3]/div/div[5]/div/div[2]/div[2]/table/tbody/tr[5]/td[4]/span")]
        private IWebElement datePickComplex;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"sidebar\"]/div/div[1]/div/div/div[2]/div[3]/div/div[5]/div/div[2]/div[1]/table/tbody/tr[3]/td[4]")]
        private IWebElement earlyDate;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"sidebar\"]/div/div[1]/div/div/div[2]/div[4]/div[1]/div[1]")]
        private IWebElement returnFlight;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"sidebar\"]/div/div[1]/div/div/div[2]/div[3]/div/div[5]/div/div[2]/div[2]/table/tbody/tr[5]/td[2]/span")]
        private IWebElement datePickSecond;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"sidebar\"]/div/div[1]/div/div/div[2]/div[4]/div[2]/div[1]/div[3]")]
        private IWebElement listOfPersons;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"sidebar\"]/div/div[1]/div/div/div[2]/div[4]/div[2]/ul[1]/li[1]/div[1]")]
        private IWebElement plusAdult;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"sidebar\"]/div/div/div[2]/div[1]/div/div/div[2]/div[4]/div[2]/ul[1]/li[1]/div[2]")]
        private IWebElement minusAdult;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"sidebar\"]/div/div[1]/div/div/div[2]/div[4]/div[2]/ul[1]/li[1]")]
        private IWebElement checkAdult;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"sidebar\"]/div/div[1]/div/div/div[2]/div[4]/div[2]/ul[1]/li[3]")]
        private IWebElement checkBaby;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"sidebar\"]/div/div[1]/div/div/div[2]/div[4]/div[2]/ul[1]/li[2]")]
        private IWebElement checkChild;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"sidebar\"]/div/div[1]/div/div/div[2]/div[4]/div[2]/ul[1]/li[3]/div[1]")]
        private IWebElement plusBaby;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"sidebar\"]/div/div[1]/div/div/div[2]/div[4]/div[2]/ul[1]/li[2]/div[1]")]
        private IWebElement plusChild;
        
        [FindsBy(How = How.XPath, Using = "//*[@id=\"sidebar\"]/div/div[1]/div/div/div[2]/div[4]/div[2]/ul[1]/li[3]/div[3]/span[1]")]
        private IWebElement summaryBaby;
        
        [FindsBy(How = How.XPath, Using = "//*[@id=\"sidebar\"]/div/div[1]/div/div/div[2]/div[4]/div[2]/ul[1]/li[1]/div[3]/span[1]")]
        private IWebElement summaryPersons;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"sidebar\"]/div/div[1]/div/div/div[2]/div[4]/div[2]/ul[1]/li[2]/div[3]/span[1]")]
        private IWebElement summaryChild;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"sidebar\"]/div/div/div/div/div[2]/div[4]/a")]
        private IWebElement searchFlight;

        [FindsBy(How = How.ClassName, Using = "noResults-title")]
        private IWebElement resultSearch;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"sidebar\"]/div/div[1]/div/div/div[2]/div[2]/ul/li[2]/div[1]/div[1]/div[1]/div[1]")]
        private IWebElement confirmReturnFlight;

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

        public void DeleteOnePerson()
        {
            minusAdult.Click();
        }

        public void AddNewBaby()
        {
            plusBaby.Click();
        }

        public void AddNewChild()
        {
            plusChild.Click();
        }

        public bool CheckAdultMinus()
        {
            if (checkAdult.GetAttribute("class") == "ui-select-item ui-select-item-adult not-minus")
            {
                return false;
            }
            return true;
        }
              
        public bool CheckNumberOfPerson()
        {
            if(summaryPersons.Text == "x 6")
            {
                return false;
            }
            if (checkBaby.GetAttribute("class") == "ui-select-item ui-select-item-infant  not-plus")
            {
                return false;
            }
            return true;     
        }

        public bool CheckMaxNumberOfPerson()
        {
            string baby = summaryBaby.Text.ToString();
            string adult = summaryPersons.Text.ToString();
            string child = summaryChild.Text.ToString();
            baby = baby.Replace("x ", string.Empty);
            adult = adult.Replace("x ", string.Empty);
            child = child.Replace("x ", string.Empty);
            if ((Int32.Parse(baby)+ Int32.Parse(adult)+ Int32.Parse(child)) >= 9)
            {
                return false;
            }
            else
                return true;
        }

        public void ReturnFlight()
        {
            returnFlight.Click();
        }

        public void ComplexFlight()
        {
            complexFlight.Click();
        }

        public void FlightSearch()
        {
            searchFlight.Click();
        }

        public void FillCityFrom(string city_from)
        {
            cityFrom.SendKeys(city_from);
        }

        public void FillComplexCityFrom(string city_from)
        {
            cityComplexFrom.Clear();
            cityComplexFrom.SendKeys(city_from);
        }

        public void FillCityTo(string city_to)
        {
            cityTo.SendKeys(city_to);
        }

        public void FillComplexCityTo(string city_to)
        {
            cityComplexTo.SendKeys(city_to);
        }

        public void FillDate()
        {          
            date.Click();
            datePick.Click();  
        }

        public void FillComplexDate()
        {
            dateComplex.Click();
            datePickComplex.Click();
        }

        public bool FillEarlyDate()
        {
            if(earlyDate.GetAttribute("class") != " inactive awadCalendar-day")
            {
                date.Click();
                earlyDate.Click();
                return true;
            }
            else
                return false;      
        }

        public IWebElement AddSecondDate()
        {
            datePickSecond.Click();
            return confirmReturnFlight;
        }

        public string GetResultOfSearch()
        {
            try
            {
                if (resultSearch.Text.ToString() == "There are no flights for the chosen dates.")
                {
                    return resultSearch.Text.ToString();
                }
                return "";
            }
            catch
            {
                return "There are no flights for the chosen dates.";
            }     
        }       
    }
}
