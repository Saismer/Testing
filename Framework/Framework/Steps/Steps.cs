using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Framework.Steps
{
    class Steps
    {
        public IWebDriver driver;

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

        //Trying to add more than 6 adult 
        public string AddAdults()
        {
            Pages.MainPage mainPage = new Pages.MainPage(driver);
            for (;;)
            {
                if(mainPage.summaryPersons.Text != "x 6")
                {
                    mainPage.AddNewPerson();
                    System.Threading.Thread.Sleep(1000);
                }
                else
                    return "The amount of adult can't be more than 6";
            }
            return "false";
        }
    }
}
