using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Remote;


namespace IbrightDriveAutomation.Appium
{
     
      
    public class Driver
    {
        
        public static AndroidDriver Instance { get; set; }

        public static string BaseAddress
        {
            get { return "http://localhost:21271/"; }
        }

        public static void Initialize()
        {
            // setting desired capabilities
            var cap = new DesiredCapabilities();
            cap.SetCapability(MobileCapabilityType.PlatformName, MobilePlatform.Android);


            // cap.setCapability(MobileCapabilityType.DEVICE_NAME,
            // "Android Emulator");
            cap.SetCapability(MobileCapabilityType.DeviceName, "Android device");

            cap.SetCapability(MobileCapabilityType.AppPackage,
                    "com.itelematic.drive.dashboard");

            cap.SetCapability(MobileCapabilityType.AppActivity,
                    "DashboardActivity");

            cap.SetCapability(MobileCapabilityType.NewCommandTimeout, "3000");


            Instance = new AndroidDriver(new Uri("http://localhost:4723/wd/hub"),
                    cap);
        }
    }
}
