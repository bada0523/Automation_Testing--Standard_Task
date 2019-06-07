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

                // Create an class and object to call the method
                Profile obj = new Profile();
                obj.EditProfile();

            }

            [Test]
            public void AddShareSkill()
            {
                //Creates a toggle for the given test, adds all log events under it
                test = extent.StartTest("Search for a Property");

                //Create an class and object to call the method
                ShareSkillApplication obj = new ShareSkillApplication();
                obj.AddShareSkill();

            }

            [Test]
            public void ViewShareSkill()
            {
                //Creates a toggle for the given test, adds all log events under it
                test = extent.StartTest("Search for a Property");

                //Create an class and object to call the method
                ManageListings obj = new ManageListings();
                obj.ViewShareSkill();
            }

            [Test]
            public void EditShareSkill()
            {
                //Creates a toggle for the given test, adds all log events under it
                test = extent.StartTest("Search for a Property");

                //Create an class and object to call the method
                ManageListings obj = new ManageListings();
                obj.EditShareSkill();
            }

            [Test]
            public void DeleteShareSkill()
            {
                //Creates a toggle for the given test, adds all log events under it
                test = extent.StartTest("Search for a Property");

                //Create an class and object to call the method
                ManageListings obj = new ManageListings();
                obj.EditShareSkill();
            }

            [Test]
            public void isActivatedShareSkill()
            {
                //Creates a toggle for the given test, adds all log events under it
                test = extent.StartTest("Search for a Property");

                //Create an class and object to call the method
                ManageListings obj = new ManageListings();
                obj.isActivated();
            }
        }
    }
}