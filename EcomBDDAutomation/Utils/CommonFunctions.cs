
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.ObjectModel;
using System.Drawing;

namespace EcomBDDAutomation.Utils
{
   public class CommonFunctions
    {
        public static IWebDriver driver;
        static string USERNAME = "rohinkumar1";
        static string AUTOMATE_KEY = "TezTS4Woy4cVr3Lxomr4";

        public static void openBrowser()
        {
            DesiredCapabilities caps = new DesiredCapabilities();

            caps.SetCapability("os", "Windows");
            caps.SetCapability("os_version", "10");
            caps.SetCapability("browser", "Chrome");
            caps.SetCapability("browser_version", "80");
            caps.SetCapability("browserstack.user", USERNAME);
            caps.SetCapability("browserstack.key", AUTOMATE_KEY);
            caps.SetCapability("name", "rohinkumar1's First Test");
            driver = new RemoteWebDriver(
              new Uri("https://hub-cloud.browserstack.com/wd/hub/"), caps
            );
            
            //driver.Manage().Window.Size = new Size(414, 736);
            /* //Handling multiple windows
             ReadOnlyCollection<string> windows = driver.WindowHandles;
             driver.SwitchTo().Window(windows[2]);
             //Do actions in second window
             driver.SwitchTo().Window(windows[1]);
             //  driver.Manage().Window.Maximize();
             // windowHandle

             //IFrame
             driver.SwitchTo().Frame(driver.FindElement(By.Id("")));
             //actions
             // driver.SwitchTo().Window(windows[1]); //iframe 
             driver.SwitchTo().DefaultContent();

             //Handling Javascript alerts

             // driver.SwitchTo().Alert().Accept();

             //driver.SwitchTo().Alert().Dismiss();

             IAlert alert = driver.SwitchTo().Alert();
             //alert.Text = ""*/

            /*CommonFunctions commonFunctions = new CommonFunctions();
            commonFunctions.KeyIn(Keys.LeftControl);


            //JavaScriptExceutor

            IJavaScriptExecutor scriptExecutor = ((IJavaScriptExecutor)driver);
            scriptExecutor.ExecuteScript("document.getElementById('').click()");
            scriptExecutor.ExecuteScript("document.getElementById('').inneHTML = '' ");
            scriptExecutor.ExecuteScript("document.getElementById('').value = '' ");

            IWebElement buttonJs = driver.FindElement(By.XPath(""));

            scriptExecutor.ExecuteScript("arguments[0].click", buttonJs);
            scriptExecutor.ExecuteScript("window.scrollBy(0,600)");*/




        }

        public static void closeBrowser()
        {
            
            driver.Quit();
        }


        public void KeyIn(string key)
        {
            Actions actions = new Actions(driver);
            actions.KeyUp(key).KeyDown(key).Build().Perform();
        }

        public void JSClick(IWebElement element)
        {
            IJavaScriptExecutor scriptExecutor = ((IJavaScriptExecutor)driver);
            scriptExecutor.ExecuteScript("arguments[0].click", element);

        }
    }
}
