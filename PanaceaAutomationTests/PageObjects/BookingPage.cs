using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace PanaceaAutomationTests.Pages
{


    namespace PanaceaAutomationTests.Pages
    {
        public class BookingPage : BasePage
        {
            private readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);

            // Room info selectors
            private readonly By roomTitle = By.CssSelector(".room-title");
            private readonly By roomPricePerNight = By.XPath("//div[contains(text(),'Price Summary')]");
            private readonly By roomDescription = By.XPath("//h2[normalize-space()='Room Description']/following-sibling::p[1]");
            private readonly By roomFeaturesContainer = By.XPath("//h2[normalize-space()='Room Features']/following-sibling::div[1]");
            private readonly By bookingFormHeader = By.XPath("//h2[contains(text(),'Book This Room')]");
            

            private readonly By checkInInput = By.XPath("//label[normalize-space()='Check In']/following::input[1]");

            private readonly By checkOutInput = By.XPath("//label[normalize-space()='Check Out']/following::input[1]");

            private readonly By checkAvailabilityButton = By.XPath("//button[normalize-space()='Check Availability']");

            // Rooms section (result of availability search)
            private readonly By roomsSection = By.Id("rooms"); // adjust if different

            // Form field selectors
            private readonly By firstNameInput = By.CssSelector("input[placeholder='Firstname']");
            private readonly By lastNameInput = By.CssSelector("input[placeholder='Lastname']");
            private readonly By emailInput = By.CssSelector("input[placeholder='Email']");
            private readonly By phoneInput = By.CssSelector("input[placeholder='Phone']");

            // Buttons selectors
            private readonly By reserveButton = By.Id("doReservation");
            private readonly By cancelButton = By.XPath("//button[normalize-space()='Cancel']");

            // Price summary details selectors
            private readonly By totalPriceValue = By.XPath("//span[normalize-space()='Total']/following-sibling::span[1]");

            // Form body selector
            // If booking-card is a custom element tag keep as-is; if it's a class change to ".booking-card"
            private readonly By bookingForm = By.CssSelector("booking-card");

            private readonly By bookingConfirmedHeader = By.XPath("//h2[normalize-space()='Booking Confirmed']");
            private readonly By confirmedDates = By.XPath("//p[contains(text(),'Your booking has been confirmed')]");

            public BookingPage(IWebDriver driver) : base(driver) { }


            private WebDriverWait Wait => new WebDriverWait(driver, DefaultTimeout);

            public void WaitForBookingPageToLoad()
            {
                wait.Until(driver => driver.Url.Contains("room")
                      || driver.Url.Contains("booking")
                      || driver.Url.Contains("reservation"));


            }
            private IWebElement WaitForClickableElement(By by)
            {
                return Wait.Until(ExpectedConditions.ElementToBeClickable(by));
            }

            public void EnterCheckInDate(string date)
            {
                var input = WaitForClickableElement(checkInInput);

                input.Clear();
                input.SendKeys(date);
                input.SendKeys(Keys.Tab);   // closes the datepicker after selecting date 
            }

            public void EnterCheckOutDate(string date)
            {
                var input = WaitForClickableElement(checkOutInput);

                input.Clear();
                input.SendKeys(date);
                input.SendKeys(Keys.Tab);  // closes the datepicker again after selecting date
            }

            public void ClickCheckAvailability()
            {
                var button = WaitForClickableElement(checkAvailabilityButton);

                ((IJavaScriptExecutor)driver)
                    .ExecuteScript("arguments[0].scrollIntoView({block: 'center'});", button);

                button.Click();
            }


            // Room information
            public string GetRoomTitle() => WaitAndGetText(roomTitle);
            public string GetRoomDescription() => WaitAndGetText(roomDescription);
            
            public string GetRoomFeaturesText() => WaitAndGetText(roomFeaturesContainer);

            
            
            // Form actions
            public bool IsBookingFormVisible()
            {
                try
                {
                    wait.Until(ExpectedConditions.ElementExists(bookingFormHeader));
                    return driver.FindElement(bookingFormHeader).Displayed;
                }
                catch
                {
                    return false;
                }
            }

            public string GetPricePerNight()
            {
                try
                {
                    wait.Until(ExpectedConditions.ElementExists(roomPricePerNight));
                    return driver.FindElement(roomPricePerNight).Text.Trim();
                }
                catch
                {
                    return string.Empty;
                }
            }

            //private readonly By selectedDate = By.CssSelector(".rbc-date-cell button");


            public void SelectBookingDate()
            {
                // Wait for any date cell to be clickable
                var dateButton = wait.Until(
                    ExpectedConditions.ElementToBeClickable(
                        By.CssSelector(".rbc-date-cell button")
                    )
                );

                // Scroll into view
                ((IJavaScriptExecutor)driver).ExecuteScript(
                    "arguments[0].scrollIntoView({block:'center'});", dateButton);

                Thread.Sleep(150); // allow layout to settle

                try
                {
                    dateButton.Click();
                }
                catch (ElementClickInterceptedException)
                {
                    ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", dateButton);
                }
            }

            public void EnterFirstName(string firstName) => WaitAndSendKeys(firstNameInput, firstName);
            public void EnterLastName(string lastName) => WaitAndSendKeys(lastNameInput, lastName);
            public void EnterEmail(string email) => WaitAndSendKeys(emailInput, email);
            public void EnterPhone(string phone) => WaitAndSendKeys(phoneInput, phone);

            public void ClickReserveNow() => Wait.Until(ExpectedConditions.ElementToBeClickable(reserveButton)).Click();
            public void ClickCancel() => Wait.Until(ExpectedConditions.ElementToBeClickable(cancelButton)).Click();

            // Price Summary
            public string GetTotalPrice() => WaitAndGetText(totalPriceValue);

            // Validating all form fields are present
            public bool AreAllFormFieldsVisible() =>
                IsElementVisible(firstNameInput) &&
                IsElementVisible(lastNameInput) &&
                IsElementVisible(emailInput) &&
                IsElementVisible(phoneInput) &&
                IsElementVisible(reserveButton) &&
                IsElementVisible(cancelButton);

            public bool AreConfirmedDatesDisplayed() => IsElementVisible(confirmedDates);
            public bool IsBookingSuccessful() => IsElementVisible(bookingConfirmedHeader);

            // --- Helper wrappers ---
            private string WaitAndGetText(By by)
            {
                try
                {
                    var el = Wait.Until(ExpectedConditions.ElementIsVisible(by));
                    return el.Text.Trim();
                }
                catch
                {
                    return string.Empty;
                }
            }

            private void WaitAndSendKeys(By by, string text)
            {
                var el = Wait.Until(ExpectedConditions.ElementIsVisible(by));
                el.Clear();
                el.SendKeys(text);
            }

            private bool IsElementVisible(By by)
            {
                try
                {
                    return Wait.Until(ExpectedConditions.ElementIsVisible(by)).Displayed;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}
