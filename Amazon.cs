using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V107.Page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonProject
{
    public class Amazon
    {
        private IWebDriver driver;
        private Pages pages;

        public Amazon(IWebDriver driver)
        {
            this.driver = driver;
            this.driver.Url = "https://www.amazon.com/?language=en_US&currency=USD";

        }
        public Pages Pages
        {
            get
            {
                if (this.pages == null)
                {
                    this.pages = new Pages(driver);
                }
                return this.pages;
            }
                
        } 
    }
}
