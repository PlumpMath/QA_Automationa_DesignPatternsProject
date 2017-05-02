using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DesignPatternsProject.Pages.ToolsQAHomePage
{
   
    public partial class ToolsQAHomePage
    {
        public IWebElement Logo
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(".//*[@id=\'page\']/div[1]/header/div/a/img")));
                return this.Driver.FindElement(By.XPath(".//*[@id=\'page\']/div[1]/header/div/a/img"));
            }
        }
    }
    
}
