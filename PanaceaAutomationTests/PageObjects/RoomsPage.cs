using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace PanaceaAutomationTests.Pages
{
    public class RoomsPage : BasePage
    {
        private readonly By roomCards = By.CssSelector(".room-card");
        private readonly By roomNames = By.CssSelector(".room-card .card-title");
        private readonly By roomDescriptions = By.CssSelector(".room-card .card-text");
        private readonly By roomPrices = By.CssSelector(".room-card .fw-bold");


        public RoomsPage(IWebDriver driver) : base(driver) { }

        // Check if rooms section contains any room cards
        public bool AreRoomsDisplayed()
        {
            try
            {
                return FindElement(roomCards).Displayed;
            }
            catch
            {
                return false;
            }
        }


        // Verify all room cards have name, price, description
        public bool RoomsHaveNamePriceAndDescription()
        {
            var names = driver.FindElements(roomNames);
            var prices = driver.FindElements(roomPrices);
            var descriptions = driver.FindElements(roomDescriptions);

            return names.Any() && prices.Any() && descriptions.Any();
        }

        // Helper methods to retrieve room data
        public IEnumerable<string> GetRoomNames() => driver.FindElements(roomNames).Select(e => e.Text);
        public IEnumerable<string> GetRoomPrices() => driver.FindElements(roomPrices).Select(e => e.Text);
        public IEnumerable<string> GetRoomDescriptions() => driver.FindElements(roomDescriptions).Select(e => e.Text);
    }
}
