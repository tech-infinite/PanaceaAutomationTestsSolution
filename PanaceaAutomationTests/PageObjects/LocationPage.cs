using OpenQA.Selenium;
using PanaceaAutomationTests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanaceaAutomationTests.PageObjects
{
    public class LocationPage : BasePage
    {
        private readonly By locationSection = By.Id("location");
        private readonly By mapElement = By.CssSelector("pigeon-tiles-box");
        private readonly By contactElement = By.XPath("//h3[text()='Contact Information']");
        private readonly By addressElement = By.XPath("//h5[text()='Address']");
        private readonly By phoneElement = By.XPath("//h5[text()='Phone']");
        private readonly By emailElement = By.XPath("//h5[text()='Email']");
        private readonly By directionsElement = By.XPath("//h4[text()='Getting Here']/following-sibling::p");


        public LocationPage(IWebDriver driver) : base(driver)
        {

        }

        // Check if location section is displayed
        public bool IsLocationSectionVisible() => FindElement(locationSection).Displayed;
        // Check if map element is displayed
        public bool IsMapVisible() => FindElement(mapElement).Displayed;

        // Check if contact information is displayed
        public bool IsContactInformationVisible() => FindElement(contactElement).Displayed;

        public bool IsAddressVisible() => FindElement(addressElement).Displayed;
        public bool IsPhoneVisible() => FindElement(phoneElement).Displayed;
        public bool IsEmailVisible() => FindElement(emailElement).Displayed;
        public bool IsDirectionsVisible() => FindElement(directionsElement).Displayed;
    }
}
