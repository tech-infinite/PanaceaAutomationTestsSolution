using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanaceaAutomationTests.PageObjects
{
    public class HomePage : BasePage
    {
        private By RoomsNavLink = By.LinkText("Rooms");
         

        public HomePage(IWebDriver driver) : base(driver) { }



        public bool AreRoomsDisplayed()
        {
            return driver.FindElements(Rooms).Any();
        }
    }

}
