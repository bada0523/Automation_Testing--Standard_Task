using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsFramework.Pages
{
    internal class ShareSkillApplication
    {
        public ShareSkillApplication()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        #region  Initialize Web Elements 
        //Click the button Share Skill
        [FindsBy(How = How.XPath, Using = "//a[@href='/Home/ServiceListing']")]
        private IWebElement shareSkillBtn { get; set; }
        //Add Title
        [FindsBy(How = How.XPath, Using = "(//div[@class='field  ']//input)[1]")]
        private IWebElement title { get; set; }
        //Add Description
        [FindsBy(How = How.XPath, Using = "//div[@class='field  ']//textarea[1]")]
        private IWebElement description { get; set; }
        //Add Category
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'five wide')]//select[1]")]
        private IWebElement category { get; set; }
        //Choose SubCategory
        [FindsBy(How = How.XPath, Using = "(//div[@class='fields']//select)[2]")]
        private IWebElement subCategory { get; set; }
        //Add Tag
        [FindsBy(How = How.XPath, Using = "(//div[@class='ReactTags__tagInput']//input)[1]")]
        private IWebElement tag { get; set; }
        //Add Service Type
        [FindsBy(How = How.XPath, Using = "(//div[contains(@class,'ui radio')]//input)[2]")]
        private IWebElement serviceType { get; set; }
        //Add Location Type
        [FindsBy(How = How.XPath, Using = "(//div[contains(@class,'ui radio')]//input)[3]")]
        private IWebElement locationType { get; set; }
        //Add Start date
        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(1) > div:nth-child(2) > input[type='date']")]
        private IWebElement startDate { get; set; }
        //Add End date
        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(1) > div:nth-child(4) > input[type='date']")]
        private IWebElement endDate { get; set; }
        //Add Skill Trade
        [FindsBy(How = How.XPath, Using = "(//div[contains(@class,'ui radio')]//input)[5]")]
        private IWebElement skillTrade { get; set; }
        //Add Skill Exchange
        [FindsBy(How = How.XPath, Using = "(//div[@class='ReactTags__tagInput']//input)[2]")]
        private IWebElement skillExchange { get; set; }
        //Upload Work Samples
        [FindsBy(How = How.XPath, Using = "//div[@class='ui grid']//i[1]")]
        private IWebElement workSampleBtn { get; set; }
        //Choose Active
        [FindsBy(How = How.XPath, Using = "(//input[@name='isActive'])[1]")]
        private IWebElement active { get; set; }
        //Click on Save button
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'sixteen wide')]//input[1]")]
        private IWebElement saveBtn { get; set; }
        #endregion

        internal void AddShareSkill()
        {
            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");

            string mainCat = GlobalDefinitions.ExcelLib.ReadData(2, "Category");
            string subCat = GlobalDefinitions.ExcelLib.ReadData(2, "SubCategory");

            Thread.Sleep(1000);
            // Click the button Share Skill
            shareSkillBtn.Click();

            Thread.Sleep(1000);
            //Add Title
            title.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Title"));
            Thread.Sleep(500);
            //Enter Description
            description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Description"));
            Thread.Sleep(500);
            //Choose Category
            category.Click();
            IWebElement selectCat = GlobalDefinitions.driver.FindElement(By.Name("categoryId"));
            SelectElement setCat = new SelectElement(selectCat);
            setCat.SelectByText(mainCat);
            Thread.Sleep(1000);
            //Choose SubCategory
            subCategory.Click();
            IWebElement selectSubCat = GlobalDefinitions.driver.FindElement(By.Name("subcategoryId"));
            SelectElement setSubCat = new SelectElement(selectSubCat);
            setSubCat.SelectByText(subCat);
            Thread.Sleep(500);
            //Add Tag
            tag.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Tags"));
            System.Windows.Forms.SendKeys.SendWait("{Enter}");
            //Choose Service Type
            serviceType.Click();
            Thread.Sleep(1000);
            //Choose Location Type
            locationType.Click();
            Thread.Sleep(1000);
            //Choose Available Days
            startDate.SendKeys("2020-05-30");
            endDate.SendKeys("2020-08-13");
            //Choose Available Time - 10:00am to 16:00pm on Mon - Thu
            for (int i = 3; i < 7; i++)
            {
                GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[" + i + "]/div[1]/div/input")).Click();
                GlobalDefinitions.driver.FindElement(By.CssSelector("#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(" + i + ") > div:nth-child(2) > input[type='time']")).SendKeys(Keys.ArrowUp);
                GlobalDefinitions.driver.FindElement(By.CssSelector("#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(" + i + ") > div:nth-child(2) > input[type='time']")).SendKeys(Keys.Tab);
                GlobalDefinitions.driver.FindElement(By.CssSelector("#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(" + i + ") > div:nth-child(2) > input[type='time']")).SendKeys("1000");
                GlobalDefinitions.driver.FindElement(By.CssSelector("#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(" + i + ") > div:nth-child(3) > input[type='time']")).SendKeys(Keys.ArrowDown);
                GlobalDefinitions.driver.FindElement(By.CssSelector("#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(" + i + ") > div:nth-child(3) > input[type='time']")).SendKeys(Keys.Tab);
                GlobalDefinitions.driver.FindElement(By.CssSelector("#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(" + i + ") > div:nth-child(3) > input[type='time']")).SendKeys("0400");
            }
            //Choose Skill Trade
            skillTrade.Click();
            //Enter Skill-Exchange
            skillExchange.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Skill-Exchange"));
            System.Windows.Forms.SendKeys.SendWait("{Enter}");
            //Upload the file
            workSampleBtn.Click();
            Thread.Sleep(2000);
            //Please make a txt file and change the path for you
            System.Windows.Forms.SendKeys.SendWait(@"C:\Users\harri\Documents\fortesting.txt");
            System.Windows.Forms.SendKeys.SendWait("{Enter}");
            //Choose Active
            active.Click();
            //Click on Save button
            saveBtn.Click();
            Base.test.Log(LogStatus.Info, "Added a shareskill successfully");


        }
    }


}
