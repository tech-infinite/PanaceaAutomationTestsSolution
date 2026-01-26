using OpenQA.Selenium;

namespace PanaceaAutomationTests.Pages
{
    public class BookingPage : BasePage
    {
        // Room info selectors
        private readonly By roomTitle = By.CssSelector(".room-title"); // e.g.Single Room, "Double Room, etc"
        private readonly By roomPricePerNight = By.CssSelector(".price-summary .price");
        private readonly By roomDescription = By.CssSelector(".room-description");

        // Form field selectors
        private readonly By firstNameInput = By.CssSelector("input[placeholder='Firstname']");
        private readonly By lastNameInput = By.CssSelector("input[placeholder='Lastname']");
        private readonly By emailInput = By.CssSelector("input[placeholder='Email']");
        private readonly By phoneInput = By.CssSelector("input[placeholder='Phone']");

        // Buttons selectors
        private readonly By reserveButton = By.CssSelector("button:contains('Reserve Now')");
        private readonly By cancelButton = By.CssSelector("button:contains('Cancel')");

        // Price summary details selectors
        private readonly By totalPrice = By.CssSelector(".price-summary .total .price");

        public BookingPage(IWebDriver driver) : base(driver) { }

        // Selectors for room information
        public string GetRoomTitle() => FindElement(roomTitle).Text;
        public string GetRoomDescription() => FindElement(roomDescription).Text;
        public string GetPricePerNight() => FindElement(roomPricePerNight).Text;


        // Form actions
        public void EnterFirstName(string firstName) => SendKeys(firstNameInput, firstName);
        public void EnterLastName(string lastName) => SendKeys(lastNameInput, lastName);
        public void EnterEmail(string email) => SendKeys(emailInput, email);
        public void EnterPhone(string phone) => SendKeys(phoneInput, phone);

        public void ClickReserveNow() => ClickElement(reserveButton);
        public void ClickCancel() => ClickElement(cancelButton);


        // Price Summary 
        public string GetTotalPrice() => FindElement(totalPrice).Text;

        
        // Validating all form fields are present
        public bool AreAllFormFieldsVisible() =>

            FindElement(firstNameInput).Displayed &&
            FindElement(lastNameInput).Displayed &&
            FindElement(emailInput).Displayed &&
            FindElement(phoneInput).Displayed &&
            FindElement(reserveButton).Displayed &&
            FindElement(cancelButton).Displayed;
    }
}
