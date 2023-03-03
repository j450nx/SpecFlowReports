using OpenQA.Selenium;

namespace SpecFlow.StepDefinitions
{
    [Binding]
    public sealed class ReportStepDefinitions
    {
        private IWebDriver driver;

        public ReportStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"Open the browser")]
        public void GivenOpenTheBrowser()
        {
            driver = new OpenQA.Selenium.Edge.EdgeDriver();
        }

        [When(@"Enter the URL")]
        public void WhenOpenTheURL()
        {
            driver.Url = "https://www.youtube.com";
            //driver.Manage().Window.Maximize();
        }

        [Then(@"Search for Testers Talk")]
        public void ThenSearchForTestersTalk()
        {
            IWebElement searchBox = driver.FindElement(By.XPath("//*[@name='search_query']"));
            searchBox.SendKeys("Testers Talk");
            searchBox.SendKeys(Keys.Enter);
            driver.Close();
            driver.Quit();
        }
    }
}