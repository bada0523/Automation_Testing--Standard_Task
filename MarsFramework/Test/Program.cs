using MarsFramework.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsFramework
{
    public class Program
    {
        [TestFixture]
        [Category("Sprint1")]
        class Tenant : Global.Base
        {

            [Test]
            public void UserAccount()
            {
                // Creates a toggle for the given test, adds all log events under it    
                test = extent.StartTest("Search for a Property");

                // Create a class and object to call the method
                Profile obj = new Profile();
                obj.SetProfile();

            }
            [Test]
            public void SignUp()
            {
                //Creates a toggle for the given test, adds all log events under it
                test = extent.StartTest("Search for a Property");

                //Create a class and object to call the method
                SignUp obj = new SignUp();
                obj.Registration();
            }
            [Test]
            public void AddLanguage()
            {
                // Creates a toggle for the given test, adds all log events under it
                test = extent.StartTest("Search for a Property");

                //Create a class and object to call the method
                Profile obj = new Profile();
                obj.AddLanguage();
            }
            [Test]
            public void AddSkill()
            {
                // Creates a toggle for the given test, adds all log events under it
                test = extent.StartTest("Search for a Property");

                //Create a class and object to call the method
                Profile obj = new Profile();
                obj.AddSkill();
            }
            [Test]
            public void AddEducation()
            {
                // Creates a toggle for the given test, adds all log events under it
                test = extent.StartTest("Search for a Property");

                //Create a class and object to call the method
                Profile obj = new Profile();
                obj.AddEducation();
            }
            [Test]
            public void AddCertificate()
            {
                // Creates a toggle for the given test, adds all log events under it
                test = extent.StartTest("Search for a Property");

                //Create a class and object to call the method
                Profile obj = new Profile();
                obj.AddCertificate();
            }
            [Test]
            public void EditLanguage()
            {
                //Creates a toggle for the given test, adds all log events under it
                test = extent.StartTest("Search for a Property");

                //Create a class and object to call the method
                Profile obj = new Profile();
                obj.EditLanguage();
            }
            [Test]
            public void EditSkill()
            {
                //Creates a toggle for the given test, adds all log events under it
                test = extent.StartTest("Search for a Property");

                //Create a class and object to call the method
                Profile obj = new Profile();
                obj.EditSkill();
            }
            [Test]
            public void EditEducation()
            {
                //Creates a toggle for the given test, adds all log events under it
                test = extent.StartTest("Search for a Property");

                //Create a class and object to call the method
                Profile obj = new Profile();
                obj.EditEducation();
            }
            [Test]
            public void EditCertificate()
            {
                //Creates a toggle for the given test, adds all log events under it
                test = extent.StartTest("Search for a Property");

                //Create a class and object to call the method
                Profile obj = new Profile();
                obj.EditCertificate();
            }
            [Test]
            public void DeleteLanguage()
            {
                //Creates a toggle for the given test, adds all log events under it
                test = extent.StartTest("Search for a Property");

                //Create a class and object to call the method
                Profile obj = new Profile();
                obj.DeleteLanguage();
            }
            [Test]
            public void DeleteSkill()
            {
                //Creates a toggle for the given test, adds all log events under it
                test = extent.StartTest("Search for a Property");

                //Create a class and object to call the method
                Profile obj = new Profile();
                obj.DeleteSkill();
            }
            [Test]
            public void DeleteEducation()
            {
                //Creates a toggle for the given test, adds all log events under it
                test = extent.StartTest("Search for a Property");

                //Create a class and object to call the method
                Profile obj = new Profile();
                obj.DeleteEducation();
            }
            [Test]
            public void DeleteCertificate()
            {
                //Creates a toggle for the given test, adds all log events under it
                test = extent.StartTest("Search for a Property");

                //Create a class and object to call the method
                Profile obj = new Profile();
                obj.DeleteCertificate();
            }
            [Test]
            public void ChangePassword()
            {
                //Creates a toggle for the given test, adds all log events under it
                test = extent.StartTest("Search for a Property");

                //Create a class and object to call the method
                Profile obj = new Profile();
                obj.ChangePassword();
            }
            [Test]
            public void AddDescription()
            {
                //Creates a toggle for the given test, adds all log events under it
                test = extent.StartTest("Search for a Property");

                //Create a class and object to call the method
                Profile obj = new Profile();
                obj.AddDescription();
            }
            [Test]
            public void AddShareSkill()
            {
                //Creates a toggle for the given test, adds all log events under it
                test = extent.StartTest("Search for a Property");

                //Create a class and object to call the method
                ShareSkillApplication obj = new ShareSkillApplication();
                obj.AddShareSkill();

            }

            [Test]
            public void ViewShareSkill()
            {
                //Creates a toggle for the given test, adds all log events under it
                test = extent.StartTest("Search for a Property");

                //Create a class and object to call the method
                ManageListings obj = new ManageListings();
                obj.ViewShareSkill();
            }

            [Test]
            public void EditShareSkill()
            {
                //Creates a toggle for the given test, adds all log events under it
                test = extent.StartTest("Search for a Property");

                //Create a class and object to call the method
                ManageListings obj = new ManageListings();
                obj.EditShareSkill();
            }

            [Test]
            public void DeleteShareSkill()
            {
                //Creates a toggle for the given test, adds all log events under it
                test = extent.StartTest("Search for a Property");

                //Create a class and object to call the method
                ManageListings obj = new ManageListings();
                obj.DeleteShareSkill();
            }

            [Test]
            public void isActivatedShareSkill()
            {
                //Creates a toggle for the given test, adds all log events under it
                test = extent.StartTest("Search for a Property");

                //Create a class and object to call the method
                ManageListings obj = new ManageListings();
                obj.isActivated();
            }

            [Test]
            public void SearchByCategory()
            {
                //Creates a toggle for the given test, adds all log events under it
                test = extent.StartTest("Search for a Property");

                //Create as class and object to call the method
                Search obj = new Search();
                obj.SearchByCategory();
            }
        }
    }
}