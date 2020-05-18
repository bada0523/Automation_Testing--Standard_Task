using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Threading;
using static NUnit.Core.NUnitFramework;

namespace MarsFramework
{
    internal class Profile
    {
        WebDriverWait wait = new WebDriverWait(GlobalDefinitions.driver, TimeSpan.FromSeconds(15));
        public Profile()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
        }

        #region  Initialize Web Elements 
        //Click on Availability Time
        [FindsBy(How = How.XPath, Using = "(//div[contains(@class,'right floated')]//i)[1]")]
        private IWebElement availabilityTime { get; set; }

        //Click on Availability Hours
        [FindsBy(How = How.XPath, Using = "(//div[contains(@class,'right floated')]//i)[2]")]
        private IWebElement availabilityHours { get; set; }

        //Click on EarnTarget
        [FindsBy(How = How.XPath, Using = "(//div[contains(@class,'right floated')]//i)[3]")]
        private IWebElement salary { get; set; }
        //-----------------Set Profile Info-------------------------

        //Click on Language Tab
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ui top')]//a[1]")]
        private IWebElement languageTab
        {
            get; set;
        }
        //Click on Add new to add new Language
        [FindsBy(How = How.XPath, Using = "(//div[contains(@class,'ui teal')])[1]")]
        private IWebElement addNewLangBtn { get; set; }

        //Enter the Language on text box
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'five wide')]//input[1]")]
        private IWebElement addLangText { get; set; }

        //Click on Language Level dropdown menu
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'five wide')]//select[1]")]
        private IWebElement chooseLang { get; set; }

        //Click on Add button to confirm adding language
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'six wide')]//input[1]")]
        private IWebElement addLangBtn { get; set; }
        //-----------------Add Language-------------------------

        //Enter Skill Tab
        [FindsBy(How = How.XPath, Using = "(//div[contains(@class,'ui top')]//a)[2]")]
        private IWebElement skillTab { get; set; }

        //Click on Add Button to add a new skill
        [FindsBy(How = How.XPath, Using = "(//th[@class='right aligned']//div)[2]")]
        private IWebElement addNewSkillBtn { get; set; }

        //Click on Add Skill Text box
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Add Skill']")]
        private IWebElement addSkillText { get; set; }

        //Click on Skill Level dropdown menu
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'five wide')]//select[1]")]
        private IWebElement chooseSkill { get; set; }

        //Click on Add Button to Confirm adding skill
        [FindsBy(How = How.XPath, Using = "//span[@class='buttons-wrapper']//input[1]")]
        private IWebElement addSkillBtn { get; set; }
        //-----------------Add Skill-------------------------

        //Click on Educaiton Tab
        [FindsBy(How = How.XPath, Using = "(//div[contains(@class,'ui top')]//a)[3]")]
        private IWebElement eduTab { get; set; }

        //Click on Add Button to add a new education
        [FindsBy(How = How.XPath, Using = "(//th[@class='right aligned']//div)[3]")]
        private IWebElement addNewEduBtn { get; set; }

        //Enter university on the College Name text box
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ten wide')]//input[1]")]
        private IWebElement addCollegeName { get; set; }

        //Choose the country dropdown menu
        [FindsBy(How = How.XPath, Using = "(//div[contains(@class,'six wide')]//select)[1]")]
        private IWebElement chooseCountry { get; set; }

        //Choose the Title dropdown menu
        [FindsBy(How = How.XPath, Using = "(//div[contains(@class,'six wide')]//select)[2]")]
        private IWebElement chooseTitle { get; set; }

        //Enter Degree on the Degree text box
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'six wide')]//input[1]")]
        private IWebElement degree { get; set; }
        //Year of graduation
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'four wide')]//select[1]")]
        private IWebElement chooseYoG { get; set; }
        //Click on Add Button to confirm Adding Education
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'sixteen wide')]//input[1]")]
        private IWebElement addEduBtn { get; set; }
        //-----------------Add Education-------------------------

        //Click on Certifications Tab
        [FindsBy(How = How.XPath, Using = "(//div[contains(@class,'ui top')]//a)[4]")]
        private IWebElement certiTab { get; set; }

        //Click on Add New button
        [FindsBy(How = How.XPath, Using = "(//th[@class='right aligned']//div)[4]")]
        private IWebElement addNewCertiBtn { get; set; }

        //Enter Certification Name
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'sixteen wide')]//input[1]")]
        private IWebElement addCertiName { get; set; }

        //Certified from
        [FindsBy(How = How.XPath, Using = "(//div[contains(@class,'eight wide')]//input)[2]")]
        private IWebElement addCertiFrom { get; set; }

        //Year
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'three wide')]//select[1]")]
        private IWebElement chooseCertiYear { get; set; }

        //Add Ceritification
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'five wide')]//input[1]")]
        private IWebElement addCertiBtn { get; set; }
        //-----------------Add Certificates-------------------------

        //Click on Description Edit Pencil Icon
        [FindsBy(How = How.XPath, Using = "(//span[@class='button']//i)[1]")]
        private IWebElement addDescription { get; set; }

        //Type on description textarea
        [FindsBy(How = How.XPath, Using = "//div[@class='field  ']//textarea[1]")]
        private IWebElement typeDescription { get; set; }

        //Click on Save Button
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'ui twelve')]//button[1]")]
        private IWebElement saveDesc { get; set; }
        //-----------------Add Description-------------------------

        //Edit language name
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Add Language']")]
        private IWebElement editLang { get; set; }

        //Edit Skill name
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Add Skill']")]
        private IWebElement editSkill { get; set; }

        //Click on Language, Skill Level
        [FindsBy(How = How.Name, Using = "level")]
        private IWebElement editLevel { get; set; }
        //---------------Edit Language, Skill---------------------

        //Edit College name
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='College/University Name']")]
        private IWebElement editCollege { get; set; }

        //Click on Country
        [FindsBy(How = How.Name, Using = "country")]
        private IWebElement editCountry { get; set; }

        //Click on Title
        [FindsBy(How = How.Name, Using = "title")]
        private IWebElement editTitle { get; set; }

        //Edit Degree name
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Degree']")]
        private IWebElement editDegree { get; set; }

        //Click on Year of Graduation
        [FindsBy(How = How.Name, Using = "yearOfGraduation")]
        private IWebElement yrOfGraduation { get; set; }

        //Click on Update Button
        [FindsBy(How = How.XPath, Using = "//input[@value='Update']")]
        private IWebElement updateBtn { get; set; }
        //-----------------Edit Education-------------------------

        //Edit Certificate Name
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Certificate or Award']")]
        private IWebElement editCertName { get; set; }

        //Edit From
        [FindsBy(How = How.XPath, Using = "//input[@class='received-from capitalize']")]
        private IWebElement editFrom { get; set; }

        //Click on Year of Certification
        [FindsBy(How = How.Name, Using = "certificationYear")]
        private IWebElement certYr { get; set; }
        //-----------------Edit Certificate-------------------------

        //Move on "Hi Harris" text
        [FindsBy(How = How.XPath, Using = "(//div[contains(@class,'ui compact')]//span)[2]")]
        private IWebElement idDropdown { get; set; }

        //Click Change Password on dropdown
        [FindsBy(How = How.XPath, Using = "(//a[@class='item'])[4]")]
        private IWebElement changePwd { get; set; }

        //Enter Current Password
        [FindsBy(How = How.XPath, Using = "(//input[@type='password'])[1]")]
        private IWebElement currentPwd { get; set; }
        //Enter New Password
        [FindsBy(How = How.XPath, Using = "(//input[@type='password'])[2]")]
        private IWebElement NewPwd { get; set; }
        //Enter Confirm Password
        [FindsBy(How = How.XPath, Using = "(//input[@type='password'])[3]")]
        private IWebElement ConfirmPwd { get; set; }
        //Click on Save Button
        [FindsBy(How = How.XPath, Using = "//div[@class='field']//button[1]")]
        private IWebElement saveBtn { get; set; }

        #endregion

        internal void SetProfile()
        {

            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");

            //get rowname
            string AvailableTime = GlobalDefinitions.ExcelLib.ReadData(2, "AvailableTime");
            string AvailableHours = GlobalDefinitions.ExcelLib.ReadData(2, "AvailableHours");
            string EarnTarget = GlobalDefinitions.ExcelLib.ReadData(2, "EarnTarget");

            //Availability Time option
            Thread.Sleep(1500);
            availabilityTime.Click();
            IWebElement selectTime = GlobalDefinitions.driver.FindElement(By.Name("availabiltyType"));
            SelectElement setTime = new SelectElement(selectTime);
            setTime.SelectByText(AvailableTime);
            Base.test.Log(LogStatus.Info, "Set Available Time successfully");
            Thread.Sleep(1000);

            ////Availability Hours
            availabilityHours.Click();
            IWebElement selectHours = GlobalDefinitions.driver.FindElement(By.Name("availabiltyHour"));
            SelectElement setHours = new SelectElement(selectHours);
            setHours.SelectByText(AvailableHours);
            Base.test.Log(LogStatus.Info, "Set Hours successfully");
            Thread.Sleep(1000);

            ////Earn Target
            salary.Click();
            IWebElement selectSalary = GlobalDefinitions.driver.FindElement(By.Name("availabiltyTarget"));
            SelectElement setSalary = new SelectElement(selectSalary);
            setSalary.SelectByText(EarnTarget);
            Base.test.Log(LogStatus.Info, "Set Salary successfully");
        }
        ////---------------------------------------------------------
        internal void AddLanguage()
        {
            string langLevel = GlobalDefinitions.ExcelLib.ReadData(2, "Choose Language Level");

            //Click on Add New Language button
            Thread.Sleep(3000);
            addNewLangBtn.Click();
            Thread.Sleep(1000);
            //Enter the Language
            addLangText.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Language"));
            //Select the Language Level
            chooseLang.Click();
            IWebElement selectLangLevel = GlobalDefinitions.driver.FindElement(By.Name("level"));
            SelectElement setLangLevel = new SelectElement(selectLangLevel);
            setLangLevel.SelectByText(langLevel);
            //Click Add Button
            addLangBtn.Click();
            //Leave test log
            Base.test.Log(LogStatus.Info, "Added a Language successfully");
        }

        internal void AddSkill()
        {
            string skillLevel = GlobalDefinitions.ExcelLib.ReadData(2, "Choose Skill Level");

            //Click Skills Tab
            skillTab.Click();
            Thread.Sleep(1000);
            //Click on Add New Skill Button
            addNewSkillBtn.Click();
            Thread.Sleep(1000);
            //Enter the skill 
            addSkillText.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Skill"));
            //Select the skill dropdown
            chooseSkill.Click();
            IWebElement selectSkillLevel = GlobalDefinitions.driver.FindElement(By.Name("level"));
            SelectElement setSkillLevel = new SelectElement(selectSkillLevel);
            setSkillLevel.SelectByText(skillLevel);
            //Click Add Button
            addSkillBtn.Click();
            //Leave test log
            Base.test.Log(LogStatus.Info, "Added a Skill successfully");
        }

        internal void AddEducation()
        {
            string country = GlobalDefinitions.ExcelLib.ReadData(2, "Country");
            string title = GlobalDefinitions.ExcelLib.ReadData(2, "Title");
            string yearOfGraduation = GlobalDefinitions.ExcelLib.ReadData(2, "Year of Graduation");

            //Click Education Tab
            eduTab.Click();
            Thread.Sleep(1000);
            //Click on Add new Education Button
            addNewEduBtn.Click();
            Thread.Sleep(1000);
            //Enter the College Name
            addCollegeName.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "University"));
            //Select Country dropdown
            chooseCountry.Click();
            IWebElement selectCountry = GlobalDefinitions.driver.FindElement(By.Name("country"));
            SelectElement setCountry = new SelectElement(selectCountry);
            setCountry.SelectByText(country);
            //Select Title
            chooseTitle.Click();
            IWebElement selectTitle = GlobalDefinitions.driver.FindElement(By.Name("title"));
            SelectElement setTitle = new SelectElement(selectTitle);
            setTitle.SelectByText(title);
            //Enter Degree
            degree.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Degree"));
            //Select Year of Graduation
            chooseYoG.Click();
            IWebElement selectYoG = GlobalDefinitions.driver.FindElement(By.Name("yearOfGraduation"));
            SelectElement setYoG = new SelectElement(selectYoG);
            setYoG.SelectByText(yearOfGraduation);
            //Click on Add button
            addEduBtn.Click();
            //Leave test log
            Base.test.Log(LogStatus.Info, "Added an Education successfully");
        }

        internal void AddCertificate()
        {
            string yearOfCertification = GlobalDefinitions.ExcelLib.ReadData(2, "Year of Certification");

            //Click Certifications Tab
            certiTab.Click();
            Thread.Sleep(1000);
            //Click on Add New Button
            addNewCertiBtn.Click();
            Thread.Sleep(1000);
            //Enter the Certification Name
            addCertiName.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Certificate"));
            //Enter the certification from
            addCertiFrom.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "CertifiedFrom"));
            //Select Year of Certification
            chooseCertiYear.Click();
            IWebElement selectYoC = GlobalDefinitions.driver.FindElement(By.Name("certificationYear"));
            SelectElement setYoC = new SelectElement(selectYoC);
            setYoC.SelectByText(yearOfCertification);
            //Click on Add Button
            addCertiBtn.Click();
            //Leave test log
            Base.test.Log(LogStatus.Info, "Added a Certification successfully");
        }

        internal void AddDescription()
        {
            Thread.Sleep(5000);
            //Click on Add description pencil icon
            addDescription.Click();
            Thread.Sleep(1000);
            //Enter the description
            typeDescription.Clear();
            Thread.Sleep(1000);
            //Type description
            typeDescription.SendKeys("Typing a description successfully");
            //Click on Save Button
            saveDesc.Click();
        }

        internal void EditLanguage()
        {
            //Edit a language
            Thread.Sleep(5000);
            IWebElement tableElement = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table"));
            IList<IWebElement> tableRow = tableElement.FindElements(By.TagName("tbody"));
            IList<IWebElement> rowTD;
            Boolean result = false;
            int i = 1;
            int j = 2;

            foreach (IWebElement row in tableRow)
            {

                rowTD = row.FindElements(By.TagName("td"));
                if (rowTD[0].Text.Equals("Korean"))
                {
                    IWebElement editIcon = GlobalDefinitions.driver.FindElement(By.XPath("(//i[contains(@class,'outline write')])[" + j + "]"));

                    editIcon.Click();
                    Thread.Sleep(1000);
                    editLang.Clear();
                    editLang.SendKeys("Edited");
                    editLevel.Click();
                    IWebElement selectLangLv = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div/div[2]/select/option[2]"));
                    selectLangLv.Click();
                    Thread.Sleep(1000);
                    updateBtn.Click();
                    result = true;
                    Thread.Sleep(1500);
                    //Verify successfull message
                    Assert.AreEqual(GlobalDefinitions.driver.FindElement(By.XPath("//div[contains(@class,'ns-box ns-growl')]//div[1]")).Text, "Edited has been updated to your languages");
                }
                i++;
                j++;
            }
            Thread.Sleep(1000);
            if (result == false)
            {
                Console.WriteLine("Korean language does not exist on Languages");
            }
        }
        internal void EditSkill()
        {
            //Edit a skill
            Thread.Sleep(1000);
            skillTab.Click();
            Thread.Sleep(3000);
            IWebElement tableElement = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table"));
            IList<IWebElement> tableRow = tableElement.FindElements(By.TagName("tbody"));
            IList<IWebElement> rowTD;
            Boolean result = false;
            int i = 1;
            int j = 4;

            foreach (IWebElement row in tableRow)
            {
                rowTD = row.FindElements(By.TagName("td"));

                if (rowTD[0].Text.Equals("Automation Testing"))
                {
                    IWebElement editIcon = GlobalDefinitions.driver.FindElement(By.XPath("(//i[contains(@class,'outline write')])[" + j + "]"));

                    editIcon.Click();
                    Thread.Sleep(1000);
                    editSkill.Clear();
                    editSkill.SendKeys("Selenium");
                    editLevel.Click();
                    IWebElement selectSkillLv = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div/div[2]/select/option[4]"));
                    selectSkillLv.Click();
                    Thread.Sleep(1000);
                    updateBtn.Click();
                    result = true;
                    Thread.Sleep(1500);
                    //Verify successfull message
                    Assert.AreEqual(GlobalDefinitions.driver.FindElement(By.XPath("//div[contains(@class,'ns-box ns-growl')]//div[1]")).Text, "Selenium has been updated to your skills");
                }
                i++;
                j++;
            }
            Thread.Sleep(1000);
            if (result == false)
            {
                Console.WriteLine("Automation Testing skill does not exist on Skills");
            }
        }
        internal void EditEducation()
        {
            //Edit an education
            Thread.Sleep(1000);
            eduTab.Click();
            Thread.Sleep(2000);
            IWebElement tableElement = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table"));
            IList<IWebElement> tableRow = tableElement.FindElements(By.TagName("tbody"));
            IList<IWebElement> rowTD;
            Boolean result = false;
            int j = 1;

            foreach (IWebElement row in tableRow)
            {

                rowTD = row.FindElements(By.TagName("td"));
                if (rowTD[1].Text.Equals("MVP Studio"))
                {
                    IWebElement editIcon = GlobalDefinitions.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/table[1]/tbody[" + j + "]/tr[1]/td[6]/span[1]/i[1]"));

                    editIcon.Click();
                    Thread.Sleep(1000);
                    editCollege.Clear();
                    editCollege.SendKeys("Edited College");
                    editCountry.Click();
                    IWebElement selectCountry = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[" + j + "]/tr/td/div[1]/div[2]/select/option[102]"));
                    selectCountry.Click();
                    editTitle.Click();
                    IWebElement selectTitle = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[" + j + "]/tr/td/div[2]/div[1]/select/option[3]"));
                    selectTitle.Click();
                    editDegree.Clear();
                    editDegree.SendKeys("Edited Degree");
                    yrOfGraduation.Click();
                    IWebElement selectYr = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[" + j + "]/tr/td/div[2]/div[3]/select/option[2]"));
                    selectYr.Click();
                    Thread.Sleep(1000);
                    updateBtn.Click();
                    result = true;
                    Thread.Sleep(1500);
                    //Verify successfull message
                    Assert.AreEqual(GlobalDefinitions.driver.FindElement(By.XPath("//div[contains(@class,'ns-box ns-growl')]//div[1]")).Text, "Education as been updated");
                }
                j++;
            }
            Thread.Sleep(1000);
            if (result == false)
            {
                Console.WriteLine("MVP Studio does not exist on Education");
            }
        }
        internal void EditCertificate()
        {
            //Edit a certificate
            Thread.Sleep(1000);
            certiTab.Click();
            Thread.Sleep(2000);
            IWebElement tableElement = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table"));
            IList<IWebElement> tableRow = tableElement.FindElements(By.TagName("tbody"));
            IList<IWebElement> rowTD;
            Boolean result = false;
            int j = 1;

            foreach (IWebElement row in tableRow)
            {

                rowTD = row.FindElements(By.TagName("td"));
                if (rowTD[0].Text.Equals("Add Award"))
                {
                    IWebElement editIcon = GlobalDefinitions.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[5]/div[1]/div[2]/div[1]/table[1]/tbody[" + j + "]/tr[1]/td[4]/span[1]/i[1]"));

                    editIcon.Click();
                    Thread.Sleep(1000);
                    editCertName.Clear();
                    editCertName.SendKeys("Edited Award");
                    editFrom.Clear();
                    editFrom.SendKeys("MVP Studio");
                    certYr.Click();
                    IWebElement selectCertYr = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + j + "]/tr/td/div/div/div[3]/select/option[2]"));
                    selectCertYr.Click();
                    updateBtn.Click();
                    result = true;
                    Thread.Sleep(1500);
                    //Verify successfull message
                    Assert.AreEqual(GlobalDefinitions.driver.FindElement(By.XPath("//div[contains(@class,'ns-box ns-growl')]//div[1]")).Text, "Edited Award has been updated to your certification");
                }
                j++;
            }
            Thread.Sleep(1000);
            if (result == false)
            {
                Console.WriteLine("Add Award does not exist on Certificates");
            }
        }
        internal void DeleteLanguage()
        {
            //Delete a language
            Thread.Sleep(2000);
            IWebElement tableElement = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table"));
            IList<IWebElement> tableRow = tableElement.FindElements(By.TagName("tbody"));
            IList<IWebElement> rowTD;
            Boolean result = false;
            int j = 1;

            foreach (IWebElement row in tableRow)
            {

                rowTD = row.FindElements(By.TagName("td"));
                if (rowTD[0].Text.Equals("Edited"))
                {
                    IWebElement deleteIcon = GlobalDefinitions.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[" + j + "]/tr[1]/td[3]/span[2]/i[1]"));

                    deleteIcon.Click();
                    result = true;
                    Thread.Sleep(1500);
                    //Verify successfull message
                    Assert.AreEqual(GlobalDefinitions.driver.FindElement(By.XPath("//div[contains(@class,'ns-box ns-growl')]//div[1]")).Text, "Edited has been deleted from your languages");
                }
                j++;
            }
            Thread.Sleep(1000);
            if (result == false)
            {
                Console.WriteLine("Edited does not exist on Language");
            }
        }
        internal void DeleteSkill()
        {
            //Delete a skill
            Thread.Sleep(1000);
            //Click on skill tab
            skillTab.Click();
            Thread.Sleep(2000);
            //Count table rows
            IWebElement tableElement = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table"));
            IList<IWebElement> tableRow = tableElement.FindElements(By.TagName("tbody"));
            IList<IWebElement> rowTD;
            Boolean result = false;
            int j = 1;

            //get data from each row of table
            foreach (IWebElement row in tableRow)
            {
                //get td data from rows
                rowTD = row.FindElements(By.TagName("td"));
                //Searching for a specific keyword as Selenium
                if (rowTD[0].Text.Equals("Selenium"))
                {
                    IWebElement deleteIcon = GlobalDefinitions.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[" + j + "]/tr[1]/td[3]/span[2]/i[1]"));

                    //Click on delete icon
                    deleteIcon.Click();
                    result = true;
                    Thread.Sleep(1500);
                    //Verify successfull message
                    Assert.AreEqual(GlobalDefinitions.driver.FindElement(By.XPath("//div[contains(@class,'ns-box ns-growl')]//div[1]")).Text, "Selenium has been deleted");
                }
                j++;
            }
            Thread.Sleep(1000);
            if (result == false)
            {
                Console.WriteLine("Selenium does not exist on Skill");
            }
        }
        internal void DeleteEducation()
        {
            Thread.Sleep(1000);
            //Click on education tab
            eduTab.Click();
            Thread.Sleep(2000);
            //count table rows
            IWebElement tableElement = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table"));
            IList<IWebElement> tableRow = tableElement.FindElements(By.TagName("tbody"));
            IList<IWebElement> rowTD;
            //distingush specific keyword is searchable or not
            Boolean result = false;
            int j = 1;

            //get data from table
            foreach (IWebElement row in tableRow)
            {
                //get td data from each row
                rowTD = row.FindElements(By.TagName("td"));
                //searching specific keyword as MVP Studio
                if (rowTD[1].Text.Equals("MVP Studio"))
                {
                    IWebElement deleteIcon = GlobalDefinitions.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/table[1]/tbody[" + j + "]/tr[1]/td[6]/span[2]/i[1]"));

                    //Click on delete icon
                    deleteIcon.Click();
                    result = true;
                    Thread.Sleep(1500);
                    //Verify successfull message
                    Assert.AreEqual(GlobalDefinitions.driver.FindElement(By.XPath("//div[contains(@class,'ns-box ns-growl')]//div[1]")).Text, "Education entry successfully removed");
                }
                j++;
            }
            Thread.Sleep(1000);
            if (result == false)
            {
                Console.WriteLine("MVP Studio does not exist on Educations");
            }
        }
        internal void DeleteCertificate()
        {
            //Delete a certificate
            Thread.Sleep(1000);
            //Click on certificate tab
            certiTab.Click();
            Thread.Sleep(2000);
            //Count table rows
            IWebElement tableElement = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table"));
            IList<IWebElement> tableRow = tableElement.FindElements(By.TagName("tbody"));
            IList<IWebElement> rowTD;
            Boolean result = false;
            int j = 1;

            //get data from each row of table
            foreach (IWebElement row in tableRow)
            {
                //get td data from each row
                rowTD = row.FindElements(By.TagName("td"));
                //searching a specific keyword as Edited Award
                if (rowTD[0].Text.Equals("Edited Award"))
                {
                    IWebElement deleteIcon = GlobalDefinitions.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[5]/div[1]/div[2]/div[1]/table[1]/tbody[" + j + "]/tr[1]/td[4]/span[2]/i[1]"));

                    //Click on delete icon
                    deleteIcon.Click();
                    result = true;
                    Thread.Sleep(1500);
                    //Verify successfull message
                    Assert.AreEqual(GlobalDefinitions.driver.FindElement(By.XPath("//div[contains(@class,'ns-box ns-growl')]//div[1]")).Text, "Edited Award has been deleted from your certification");
                }
                j++;
            }
            Thread.Sleep(1000);
            if (result == false)
            {
                Console.WriteLine("Edited Award does not exist on Certificates");
            }
        }
        internal void ChangePassword()
        {
            //Change Password
            Thread.Sleep(2000);
            //Move on "Hi Harris" Text
            idDropdown.Click();
            Thread.Sleep(1000);
            //Click change password on the dropdown
            changePwd.Click();
            Thread.Sleep(1000);
            //Enter Current Password
            currentPwd.SendKeys("Test@123");
            //Enter New Password
            NewPwd.SendKeys("Test@1234");
            //Enter Confirm Password
            ConfirmPwd.SendKeys("Test@1234");
            //Click on Save Button
            saveBtn.Click();
            Thread.Sleep(1000);
            //Verify successfull message
            Assert.AreEqual(GlobalDefinitions.driver.FindElement(By.XPath("//div[contains(@class,'ns-box ns-growl')]//div[1]")).Text, "Password Changed Successfully");
        }

    }

}
