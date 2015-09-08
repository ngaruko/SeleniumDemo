using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IbrightDriveAutomation.Appium;
using IbrightDriveAutomation.Screens.Dashboard;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium;



namespace IbrightDriveAutomation.Workflows
{
    public static class SignInProcess
    {


        public static void SignIn()
        {

            Driver.Initialize();

            // Check if the user is not signed in already if
            //if (!DashboardMainScreen.IsHome())

            //{
            //    AssignEquipmentScreen.ClearPreviousSelection();

            //AssignEquipmentScreen.AddVehicle();

            //SelectVehicleScreen.ChoseVehicle();

            //SignInScreen.EnterPinCode();





            /*
		 * Scroll to see all the grid Scrolling down if device is in Portrait
		 * Scroll Right if in Landscape
		 */
            //var message = (AndroidElement) Driver.Instance.FindElementByAccessibilityId("com.itelematic.drive.dashboard:id/cardSpace");

            //if (Driver.Instance.Orientation == ScreenOrientation.Portrait)



            //    message.swipe(SwipeElementDirection.RIGHT, 1000);
            //    //  ipe(SwipeElementDirection.DOWN, 1000);

            //else
            //    message.swipe(SwipeElementDirection.RIGHT, 2000);

        }
    }

}
