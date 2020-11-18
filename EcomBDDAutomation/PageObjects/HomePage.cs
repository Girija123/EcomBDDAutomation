using EcomBDDAutomation.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;

namespace EcomBDDAutomation.PageObjects
{
   public  class HomePage
    {
        public IWebDriver driver;
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public IWebElement menuOption => driver.FindElement(By.XPath("//span[@class='PrimarynavlinksText' and text()='IMEN']"));
        public IWebElement subMenuOption => driver.FindElement(By.XPath(""));
        public IWebElement headerLink => driver.FindElement(By.XPath(""));
        public IWebElement SearchFld => driver.FindElement(By.XPath(""));
        public IWebElement searchIcon => driver.FindElement(By.XPath(""));


        public void ClickMenuOption()
        {
            CommonFunctions commonFunctions = new CommonFunctions();
            commonFunctions.JSClick(menuOption);
        }

        public void MouseOverMenu()
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(menuOption).Build().Perform();

            /* //Drag and Drop
             IWebElement src = driver.FindElement(By.XPath(""));
             IWebElement dest = driver.FindElement(By.XPath(""));
             actions.DragAndDrop(src, dest).Build().Perform();*/

            // actions.ClickAndHold(src).Release(dest).Build().Perform();

            /*IWebElement button = driver.FindElement(By.XPath(""));
            actions.MoveToElement(button).Click().Build().Perform();*/

            //Keyboard Actions
          /*  actions.KeyDown(Keys.LeftControl).KeyDown(Keys.LeftAlt).KeyDown(Keys.Delete)
                .KeyUp(Keys.LeftControl)
                .KeyUp(Keys.LeftAlt).KeyUp(Keys.Delete)
                .Build()
                .Perform();*/

            



        }


    }
}
