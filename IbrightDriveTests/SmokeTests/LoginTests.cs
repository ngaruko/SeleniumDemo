using IbrightDriveAutomation.Appium;
using IbrightDriveAutomation.Screens.Dashboard;
using NUnit.Framework;

namespace IbrightDriveTests.SmokeTests
{
    
    [TestFixture]
    public class LoginTests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [TearDown]
        public void TearDown()
        {
            
        }


        [Test]
        public void UserIsAbleToSignIn()
        {
           Driver.Initialize();
            SignoutScreen.Signout();


        }
      

        
    }	  
      
}
