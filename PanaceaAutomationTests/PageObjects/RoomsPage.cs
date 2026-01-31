using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace PanaceaAutomationTests.Pages
{
    public class RoomsPage : BasePage
    {
        private readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);

        private readonly By roomCards = By.CssSelector(".room-card");
        private readonly By roomNames = By.CssSelector(".room-card .card-title");
        private readonly By roomDescriptions = By.CssSelector(".room-card .card-text");
        private readonly By roomPrices = By.CssSelector(".room-card .fw-bold");
        private readonly By bookNowButtons = By.CssSelector(".room-card .btn-primary");

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

        public void WaitForRoomsToLoad()
        {
            wait.Until(ExpectedConditions.ElementExists(roomCards));
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
        public void ClickFirstBookNowButton()
        {
            var button = FindClickableElement(bookNowButtons);

            ((IJavaScriptExecutor)driver).ExecuteScript(
                "arguments[0].scrollIntoView({block:'center'});", button);

            Thread.Sleep(150);

            try
            {
                button.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", button);
            }
        }


        public void ClickBookNowForRoom(string roomName)
        {
            var roomCard = driver.FindElements(By.CssSelector(".room-card"))
                .First(card => card.FindElement(By.TagName("h5")).Text.Trim()
                .Equals(roomName, StringComparison.OrdinalIgnoreCase));

            roomCard.FindElement(By.CssSelector("a.btn.btn-primary")).Click();
        }



    }
}
