using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;

namespace AmazonProject
{
    public class FireFoxUnitTest
    {
        public static IWebDriver driver;
        public Dictionary<string, string> filter = new Dictionary<string, string>();

        [SetUp]
        public void startBrowser()
        {
            
            
            
            driver = BrowserFactory.InitBrowser("firefox", new List<string> {});
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            filter.Add("Price_Lower_Then", "100");
            filter.Add("Price_Hiegher_OR_Equal_Then", "50");
            filter.Add("Free_Shipping", "true");
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

