using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Framework.Steps
{
    class Steps
    {
        private IWebDriver driver;
        private double rubleValue, euroValue;

        public void InitBrowser()
        {
            driver = Driver.DriverInstance.GetInstance();
        }

        public void CloseBrowser()
        {
            Driver.DriverInstance.CloseBrowser();
        }

        public void OpenPage()
        {
            Pages.MainPage openPage = new Pages.MainPage(driver);
            openPage.OpenPage();
        }

        public void OpenListOfPersons()
        {
            Pages.MainPage mainPage = new Pages.MainPage(driver);
            mainPage.OpenList();
        }

        public bool AddAdults()
        {
            Pages.MainPage mainPage = new Pages.MainPage(driver);
            for (;;)
            {
                if (mainPage.CheckNumberOfPerson())
                {
                    mainPage.AddNewPerson();
                }
                else
                    return false;
            }
        }

        public bool AddPersons()
        {
            Pages.MainPage mainPage = new Pages.MainPage(driver);
            for(;;)
            {
                if (mainPage.CheckMaxNumberOfPerson())
                {
                    mainPage.AddNewPerson();
                    mainPage.AddNewBaby();
                    mainPage.AddNewChild();
                }
                else
                    return false;
            }
        }

        public bool DeleteAdults()
        {
            Pages.MainPage mainPage = new Pages.MainPage(driver);
            for (;;)
            {
                if (mainPage.CheckAdultMinus())
                {
                    mainPage.DeleteOnePerson();
                }
                else
                    return false;
            }
        }

        public bool AddBaby()
        {
            Pages.MainPage mainPage = new Pages.MainPage(driver);
            for(;;)
            {
                if (mainPage.CheckNumberOfPerson())
                {
                    mainPage.AddNewBaby();
                }
                else
                    return false;
            }
        }

        public void FillDataForSearching(string cityFrom,string cityTo)
        {
            Pages.MainPage mainPage = new Pages.MainPage(driver);
            mainPage.FillCityFrom(cityFrom);
            mainPage.FillCityTo(cityTo);
            
        }

        public void FillDataForComplexSearching(string cityFrom, string cityTo)
        {
            Pages.MainPage mainPage = new Pages.MainPage(driver);
            mainPage.FillComplexCityFrom(cityFrom);
            mainPage.FillComplexCityTo(cityTo);

        }

        public bool FillDate(string typeDate)
        {
            Pages.MainPage mainPage = new Pages.MainPage(driver);
            if (typeDate == "normal")
            {
                mainPage.FillDate();
                return true;
            }
            if(typeDate == "complex")
            {
                mainPage.FillComplexDate();
                return true;
            }
            else if(typeDate == "early")
            {
                if (mainPage.FillEarlyDate())
                {
                    return true;
                }
                else
                    return false;
            }
            return true;
        }

        public IWebElement AddReturnDate()
        {
            Pages.MainPage mainPage = new Pages.MainPage(driver);
            mainPage.ReturnFlight();
            return mainPage.AddSecondDate();
        }

        public void ComplexFlight()
        {
            Pages.MainPage mainPage = new Pages.MainPage(driver);
            mainPage.ComplexFlight();
        }

        public string SearchFlight(string typeSearch)
        {
            if(typeSearch == "bad flight")
            {
                Pages.MainPage mainPage = new Pages.MainPage(driver);
                mainPage.FlightSearch();
                return mainPage.GetResultOfSearch();
            }

            if(typeSearch == "complex")
            {
                return "complex flight";
            }
            return "everything is good";
        }

        public void SearchFlight()
        {
            Pages.MainPage mainPage = new Pages.MainPage(driver);
            mainPage.FlightSearch();
        }

        public void ChangeTab()
        {
            Pages.ResultPage resultPage = new Pages.ResultPage(driver);
            List<String> tabs = new List<String>(driver.WindowHandles);
            if(tabs.Count > 1)
            {
                driver.SwitchTo().Window(tabs.ElementAt(1));
            }
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"sidebar\"]/div/div[2]/ul/li[3]")));
            System.Threading.Thread.Sleep(2000);
        }
        public bool FilterResultsOfFlights()
        {
            Pages.ResultPage resultPage = new Pages.ResultPage(driver);
            ChangeTab();
            resultPage.FilterFlights();
            if (resultPage.CheckFilterFlights())
                return true;
            else
                return false;
        }

        public void ChangeCurrency()
        {
            Pages.ResultPage resultPage = new Pages.ResultPage(driver);
            ChangeTab();
            rubleValue = Double.Parse(resultPage.GetCurrencyValue());
            resultPage.ChangeCurrency();
            ChangeTab();
            euroValue = Double.Parse(resultPage.GetCurrencyValue());
        }

        public bool Calculate(double exchange)
        {
            if (rubleValue > euroValue * (exchange-0.1) && rubleValue < euroValue * (exchange + 0.1))
                return true;
            else
                return false;
        }
    }
}
