using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PanaceaAutomationTests.Utilities;
using Reqnroll;
using Reqnroll.BoDi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanaceaAutomationTests
{
    [Binding]
    public class Hooks
    {
        private readonly IObjectContainer _container;
        private IWebDriver _driver;

        public Hooks(IObjectContainer container)
        {
            _container = container;
        }

        [BeforeScenario]
        public void SetUp()
        {
            _driver = new ChromeDriver();
            _container.RegisterInstanceAs<IWebDriver>(_driver);
        }

        [AfterScenario]
        public void TearDown()
        {
            Thread.Sleep(3000); // Optional: Pause to observe the browser before closing
            _driver.Quit();
        }
    }

}
