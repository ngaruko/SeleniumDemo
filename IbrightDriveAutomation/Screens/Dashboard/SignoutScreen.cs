using  System;
using IbrightDriveAutomation.Appium;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;

using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android.Interfaces;
using OpenQA.Selenium.Appium.Interfaces;
using System;
using System.Collections.ObjectModel;




namespace IbrightDriveAutomation.Screens.Dashboard
{


    public class SignoutScreen
    {

  
        public static void Signout()
        {
 Driver.Instance.FindElementByAndroidUIAutomator("new UiSelector().resource-id(\"com.itelematic.drive.dashboard:id/action_sign_in\")");
           //Driver.Instance.FindElementByAndroidUIAutomator();

           

            //("com.itelematic.drive.dashboard:id/action_sign_in");
                //(By.Id("com.itelematic.drive.dashboard:id/action_sign_in"));

      //      //Driver.Instance.FindElementByAndroidUIAutomator("resource-id");
      //  Driver.Instance.FindElementByAccessibilityId("com.itelematic.drive.dashboard:id/action_sign_in");

      //var test=   Driver.Instance.FindElementByAndroidUIAutomator(".resource-id");
      //      test.Click();

        }
    }
}
