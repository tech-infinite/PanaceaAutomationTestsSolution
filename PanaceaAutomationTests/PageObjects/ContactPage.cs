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
        private readonly By formMessageHeader = By.XPath("//h2[text()='Send Us a Message']");
        private readonly By nameInput = By.Id("name");
        private readonly By emailInput = By.Id("email");
        private readonly By phoneInput = By.Id("phone");
        private readonly By subjectInput = By.Id("subject");
        private readonly By messageInput = By.Id("description");
        private readonly By submitButton = By.CssSelector("button[type='Submit']");
    
        public ContactPage(IWebDriver driver) : base(driver) { }


        // Form field actions
        public void EnterName(string name) => SendKeys(nameInput, name);
        public void EnterEmail(string email) => SendKeys(emailInput, email);
        public void EnterPhone(string phone) => SendKeys(phoneInput, phone);
        public void EnterSubject(string subject) => SendKeys(subjectInput, subject);
        public void EnterMessage(string message) => SendKeys(messageInput, message);
        public void ClickSubmit() => ClickElement(submitButton);


        // Form submission elements
        private readonly By successMessage = By.CssSelector(".alert-success");


        // Form visibility checks
        public bool IsContactFormVisible() => FindElement(formMessageHeader).Displayed;

        public bool IsSuccessMessageVisible() => FindElement(successMessage).Displayed;
    }
}
