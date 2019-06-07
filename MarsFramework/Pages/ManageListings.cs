using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsFramework.Pages
{
    internal class ManageListings
    {
        public ManageListings()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }
        #region  Initialize Web Elements
        //Add Title
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input")]
        private IWebElement title { get; set; }
        //Add Description
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea")]
        private IWebElement description { get; set; }
        //Add Category
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[1]/select")]
        private IWebElement category { get; set; }
        //Choose Category dropdown
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[1]/select/option[6]")]
        private IWebElement categoryOpts { get; set; }
        //Add Tag
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[4]/div[2]/div/div/div/div/input")]
        private IWebElement tag { get; set; }
        //Add Service Type
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input")]
        private IWebElement serviceType { get; set; }
        //Add Location Type
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[1]/div/input")]
        private IWebElement locationType { get; set; }
        //Add Start date
        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(1) > div:nth-child(2) > input[type='date']")]
        private IWebElement startDate { get; set; }
        //Add End date
        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(1) > div:nth-child(4) > input[type='date']")]
        private IWebElement endDate { get; set; }
        //Add Skill Trade
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[1]/div/input")]
        private IWebElement skillTrade { get; set; }
        //Add Skill Exchange
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input")]
        private IWebElement skillExchange { get; set; }
        //Upload Work Samples
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i")]
        private IWebElement workSampleBtn { get; set; }
        //Choose Active
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[1]/div/input")]
        private IWebElement active { get; set; }
        //Click on Save button
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[11]/div/input[1]")]
        private IWebElement saveBtn { get; set; }
        //Click on Manage Listings Tab
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[1]/div/a[3]")]
        private IWebElement maListings { get; set; }
        //Click on view icon
        [FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/table/tbody/tr[1]/td[8]/i[1]")]
        private IWebElement viewIcon { get; set; }
        //Click on edit icon
        [FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/table/tbody/tr[1]/td[8]/i[2]")]
        private IWebElement editIcon { get; set; }
        //Click on delete icon
        [FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/table/tbody/tr[1]/td[8]/i[3]")]
        private IWebElement deleteIcon { get; set; }
        //Click on IsActive
        [FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/table/tbody/tr[1]/td[7]/div/input")]
        private IWebElement isActive { get; set; }
        #endregion

        internal void ViewShareSkill()
        {
            Thread.Sleep(1000);
            //Click on ManageListings Tab
            maListings.Click();

            //Click on View icon
            viewIcon.Click();
        }


        internal void EditShareSkill()
        {
            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
            Thread.Sleep(1000);
            //Click on ManageListings Tab
            maListings.Click();
            Thread.Sleep(1000);
            //Click on edit icon
            editIcon.Click();
            Thread.Sleep(1000);

            //<---------------------------- Edit Share Skill ---------------------------->

            //Add Title
            title.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Title"));
            Thread.Sleep(500);
            //Enter Description
            description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Description"));
            Thread.Sleep(500);
            //Choose Category
            category.Click();
            Thread.Sleep(1000);
            categoryOpts.Click();
            Thread.Sleep(500);
            //Add Tag
            tag.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Tags"));
            //Choose Service Type
            serviceType.Click();
            Thread.Sleep(1000);
            //Choose Location Type
            locationType.Click();
            Thread.Sleep(1000);
            //Choose Available Days
            startDate.SendKeys("2019-05-30");
            endDate.SendKeys("2019-08-13");
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
            //Upload the file
            workSampleBtn.Click();
            Thread.Sleep(2000);
            //Please make a txt file and change the path for you
            System.Windows.Forms.SendKeys.SendWait(@"C:\Users\HarrisVicky\Desktop\fortesting.txt");
            System.Windows.Forms.SendKeys.SendWait("{Enter}");
            //Choose Active
            active.Click();
            //Click on Save button
            saveBtn.Click();

            //Check if user is able to search edited share skill or not
            for (int i = 1; i <= 100; i++)
            {
                string ExpectedName = "Edit1";
                string ActualName = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/table/tbody/tr[" + i + "]/td[3]")).Text;
                Thread.Sleep(500);
                if (ExpectedName == ActualName)
                {
                    Base.test.Log(LogStatus.Info, "Edited a shareskill successfully");
                    break;
                }
                else
                {

                }
            }
        }

        internal void DeleteShareSkill()
        {
            Thread.Sleep(1000);
            //Click on ManageListings Tab
            maListings.Click();
            Thread.Sleep(1000);
            //Delete a Share skill
            for (int i = 1; i <= 100; i++)
            {
                bool disPlayed = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/table/tbody/tr[" + i + "]/td[3]")).Displayed;
                Thread.Sleep(500);
                if (disPlayed)
                {
                    deleteIcon.Click();
                    Base.test.Log(LogStatus.Info, "Deleted a shareskill successfully");
                    break;
                }
                else
                {

                }
            }
        }

        internal void isActivated()
        {
            Thread.Sleep(1000);
            //Click on ManageListings Tab
            maListings.Click();
            Thread.Sleep(1000);

            //Click on isActivated
            isActive.Click();
            Thread.Sleep(1000);

            //Check if user is able to change status to activated or deactivated
            string ExpectedName = "Service has been activated";
            string ActualName = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]")).Text;
            Thread.Sleep(500);
            if (ExpectedName == ActualName)
            {
                Base.test.Log(LogStatus.Info, "The service has been activated successfully");
            }
            else
            {
                Base.test.Log(LogStatus.Info, "The service has been deactivated successfully");
            }
        }
    }
}
