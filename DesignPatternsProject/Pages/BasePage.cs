using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Configuration;
using OpenQA.Selenium.Support.UI;

namespace DesignPatternsProject.Pages
{
    public class BasePage
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        private string url;

        public BasePage(IWebDriver driver, string url, string baseKeyUrl)
        {
            this.url = ConfigurationManager.AppSettings[baseKeyUrl] + url;
            this.driver = driver;
            this.wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(10));
        }


        public void Navigate()
        {
            this.Driver.Navigate().GoToUrl(this.url);
        }

        public IWebDriver Driver
        {
            get
            {
                return this.driver;
            }
        }
        public WebDriverWait Wait
        {
            get
            {
                return this.wait;
            }
        }
    }
}
