using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace AmazonProject
{
    public class ChromeUnitTest
    {
        public static IWebDriver driver;
        public Dictionary<string, string> filter = new Dictionary<string, string>();

        [SetUp]
        public void startBrowser()
        {
            driver = BrowserFactory.InitBrowser("chrome", new List<string> {});
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            
            filter.Add("Price Lower Then", "100");
            filter.Add("Price Higher Or Equal Then", "10");
            filter.Add("Free Shipping", "true");
        }

        [Test]
        public void UnitTest()
        {
            Amazon Amazon = new Amazon(driver);
            Amazon.Pages.Home.SearchBar.Text = "mouse";
            Amazon.Pages.Home.SearchBar.Click();
            Amazon.Pages.Results.GetResultsBy(filter);
            Assert.Pass();
        }

        [TearDown]
          public void closeBrowser()
        {
                //driver.Close()
        }
        
    }
}