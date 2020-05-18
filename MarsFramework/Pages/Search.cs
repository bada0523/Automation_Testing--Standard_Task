using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsFramework.Pages
{
    internal class Search
    {
        WebDriverWait wait = new WebDriverWait(GlobalDefinitions.driver, TimeSpan.FromSeconds(15));


        public Search()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        #region Initialize Web Elements
        //Click on MarsLogo
        [FindsBy(How = How.XPath, Using = ("(//div[contains(@class,'ui secondary')]//a)[1]"))]
        private IWebElement marsLogo { get; set; }
        //Click on Category Programming Tech
        [FindsBy(How = How.XPath, Using = ("//div[@id='home']/div[1]/section[1]/div[1]/div[2]/div[1]/div[2]/div[2]/a[1]/h3[1]"))]
        private IWebElement programingCat { get; set; }
        //Click on All Categories
        [FindsBy(How = How.XPath, Using = ("(//a[@class='item subcategory'])[4]"))]
        private IWebElement subCat { get; set; }
        //Click on next page
        [FindsBy(How = How.XPath, Using = ("//button[text()='>']"))]
        private IWebElement nextPage { get; set; }
        //Keyword Search Bar
        [FindsBy(How = How.XPath, Using = ("//div[contains(@class,'ui small')]//input[1]"))]
        private IWebElement keyword { get; set; }

        #endregion

        internal void SearchByCategory()
        {
            bool exitOuterLoop = false;

            marsLogo.Click();
            Thread.Sleep(2000);
            programingCat.Click();
            Thread.Sleep(3000);
            subCat.Click();
            Thread.Sleep(3000);

            var rowCount = GlobalDefinitions.driver.FindElements(By.XPath("//*[@id='service-search-section']/div[2]/div/section/div/div[2]/div/div[2]/div/div/div")).Count;

            for (int i = 3; i <= 100; i++)
            {
                for (int j = 1; j <= rowCount; j++)
                {
                    //Expected keyword for searching
                    string ExpectedName = "Harris Jung";
                    //Reading actual keyword each Info
                    string ActualName = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='service-search-section']/div[2]/div/section/div/div[2]/div/div[2]/div/div/div[" + j + "]/div[1]/a[1]")).Text;
                    Thread.Sleep(500);
                    //Compare with actual and expected keyword
                    if (ExpectedName == ActualName)
                    {
                        //Click the keyword I am searching
                        GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='service-search-section']/div[2]/div/section/div/div[2]/div/div[2]/div/div/div[" + j + "]/a/img")).Click();
                        //Exit Outer Loop
                        exitOuterLoop = true;
                        break;
                    }
                    else
                    {
                    }
                }
                if (exitOuterLoop == false)
                {
                    //Move to Next page
                    //GlobalDefinitions.driver.FindElement(By.CssSelector("div#service-search-section>div:nth-of-type(3)>div>section>div>div:nth-of-type(2)>div>div:nth-of-type(3)>div:nth-of-type(2)>div>button:nth-of-type("+ i +")")).Click();
                    nextPage.Click();
                    Thread.Sleep(2000);
                }
                else
                {
                    break;
                }
            }
        }

        internal void SearchByKeyword()
        {
            bool exitOuterLoop = false;
            //Expected keyword for searching
            string ExpectedName = "Harris Jung";

            marsLogo.Click();
            Thread.Sleep(2000);
            keyword.SendKeys(ExpectedName);
            Thread.Sleep(3000);

            var rowCount = GlobalDefinitions.driver.FindElements(By.XPath("//*[@id='service-search-section']/div[2]/div/section/div/div[2]/div/div[2]/div/div/div")).Count;

            for (int i = 3; i <= 100; i++)
            {
                for (int j = 1; j <= rowCount; j++)
                {
                   
                    //Reading actual keyword each Info
                    string ActualName = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='service-search-section']/div[2]/div/section/div/div[2]/div/div[2]/div/div/div[" + j + "]/div[1]/a[1]")).Text;
                    Thread.Sleep(500);
                    //Compare with actual and expected keyword
                    if (ExpectedName == ActualName)
                    {
                        //Click the keyword I am searching
                        GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='service-search-section']/div[2]/div/section/div/div[2]/div/div[2]/div/div/div[" + j + "]/a/img")).Click();
                        //Exit Outer Loop
                        exitOuterLoop = true;
                        break;
                    }
                    else
                    {
                    }
                }
                if (exitOuterLoop == false)
                {
                    //Move to Next page
                    //GlobalDefinitions.driver.FindElement(By.CssSelector("div#service-search-section>div:nth-of-type(3)>div>section>div>div:nth-of-type(2)>div>div:nth-of-type(3)>div:nth-of-type(2)>div>button:nth-of-type("+ i +")")).Click();
                    nextPage.Click();
                    Thread.Sleep(2000);
                }
                else
                {
                    break;
                }
            }
        }
    }
 }
