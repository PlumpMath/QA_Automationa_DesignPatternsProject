using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DesignPatternsProject.Pages.HomePage
{
    public class HomePage :BasePage
    {
        public HomePage(IWebDriver driver)
            : base(driver, "", "demoQAURL")
        {       
        }

        [FindsBy(How = How.TagName, Using = "Demoqa | Just another WordPress site")]
        public IWebElement TagName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='menu-item-374']/a")]
        public IWebElement RegistrationButton { get; set; }

        public IWebElement RegistrationButton_
        {
            get
            {
                return Driver.FindElement(By.XPath(".//*[@id='menu-item-374']/a"));
            }
        }

        //public void Navigate()
        //{
        //    this.Driver.Navigate().GoToUrl(this.url);
        //}
    }
}
