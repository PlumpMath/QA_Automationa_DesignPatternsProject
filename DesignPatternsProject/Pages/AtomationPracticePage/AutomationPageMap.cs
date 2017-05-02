using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace DesignPatternsProject.Pages.AtomationPracticePage
{
    public partial class AutomationPage
    {
        public IWebElement NewTabButton
        { 
            get
            {
                return this.Driver.FindElement(By.XPath(".//*[@id=\'content\']/p[4]/button"));
            } 
        }
    }
}
