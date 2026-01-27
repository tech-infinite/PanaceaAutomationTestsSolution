using OpenQA.Selenium;
using PanaceaAutomationTests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanaceaAutomationTests.PageObjects
{
    public class ContactPage : BasePage
    {
        // Contact Message form field selectors
        private readonly By formMessageHeader = By.XPath("//h3[text()='Send Us a Message']");
        private readonly By nameInput = By.CssSelector("[data-testid='ContactName']");
        private readonly By emailInput = By.CssSelector("[data-testid='ContactEmail']");
        private readonly By phoneInput = By.CssSelector("[data-testid='ContactPhone']");
        private readonly By subjectInput = By.CssSelector("[data-testid='ContactSubject']");
        private readonly By messageInput = By.CssSelector("[data-testid='ContactDescription']");
        private readonly By submitButton = By.XPath("//button[normalize-space()='Submit']");

        // Form submission elements
        private readonly By successMessage = By.XPath("//h3[contains(text(),'Thanks for getting in touch')]");
        public ContactPage(IWebDriver driver) : base(driver) { }


        // Form field actions
        public void EnterName(string name) => SendKeys(nameInput, name);
        public void EnterEmail(string email) => SendKeys(emailInput, email);
        public void EnterPhone(string phone) => SendKeys(phoneInput, phone);
        public void EnterSubject(string subject) => SendKeys(subjectInput, subject);
        public void EnterMessage(string message) => SendKeys(messageInput, message);
        public void ClickSubmit() => FindElement(submitButton);


        // Form visibility checks
        public bool IsContactFormVisible() => FindElement(formMessageHeader).Displayed;

        public bool IsSuccessMessageVisible() => FindElement(successMessage).Displayed;
    }
}
