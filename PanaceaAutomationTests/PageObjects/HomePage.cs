using OpenQA.Selenium;

namespace PanaceaAutomationTests.Pages
{
    public class HomePage : BasePage
    {
        private const string BaseUrl = "https://automationintesting.online/";

        private readonly By homePageHeader = By.XPath("//a[contains(@class,'navbar-brand')]//span[contains(text(),'Shady Meadows')]");

        // Navigation links selectors
        private readonly By roomsNavLink = By.CssSelector("a.nav-link[href*='#rooms']");
        private readonly By bookingNavLink = By.CssSelector("a.nav-link[href*='#booking']");
        private readonly By amenitiesNavLink = By.Id("amenities");
        private readonly By locationNavLink = By.CssSelector("a.nav-link[href*='#location']");
        private readonly By contactNavLink = By.CssSelector("a.nav-link[href*='#contact']");
        private readonly By adminNavLink = By.CssSelector("a.nav-link[href*='admin']");
        private readonly By locationHeader = By.XPath("//h2[text()='Our Location']");


        // Sections selectors
        private readonly By roomsSection = By.CssSelector("#rooms");
        private readonly By bookingSection = By.CssSelector("#booking");
        private readonly By amenitiesSection = By.CssSelector("#amenities");
        private readonly By locationSection = By.CssSelector("#location");
        private readonly By contactSection = By.CssSelector("#contact");
        private readonly By adminSection = By.CssSelector("#admin");
        private readonly By loginForm = By.XPath("//h2[contains(text(),'Admin') or contains(text(),'Login')]");

        public HomePage(IWebDriver driver) : base(driver) { }

        public void NavigateToHomePage() => driver.Navigate().GoToUrl(BaseUrl);

        public bool IsHomePageDisplayed() =>  FindElement(homePageHeader).Displayed;


        // Scroll / anchor navigation methods
        private void ScrollToSection(By sectionNavLink) => FindClickableElement(sectionNavLink);

        public void ScrollToRoomsSection() => ScrollToSection(roomsNavLink);
        public void ScrollToBookingSection() => ScrollToSection(bookingNavLink);
        public void ScrollToAmenitiesSection() => ScrollToSection(amenitiesNavLink);
        public void ScrollToLocationSection() => ScrollToSection(locationNavLink);
        public void ScrollToContactSection() => ScrollToSection(contactNavLink);
        public void ScrollToAdminSection() => ScrollToSection(adminNavLink);

        // Section visibility checks
        public bool IsRoomsSectionVisible() => FindElement(roomsSection).Displayed;
        public bool IsBookingSectionVisible() => FindElement(bookingSection).Displayed;
        public bool IsAmenitiesSectionVisible() => FindElement(amenitiesSection).Displayed;
        public bool IsLocationSectionVisible() => FindElement(locationSection).Displayed;
        public bool IsContactSectionVisible() => FindElement(contactSection).Displayed;
        public bool IsAdminSectionVisible() => FindElement(adminSection).Displayed;

        public bool IsLocationHeaderVisible() => FindElement(locationHeader).Displayed;
        public bool IsLoginFormVisible() => FindElement(loginForm).Displayed;
    }
}
