using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace DesignPatternsProject.Pages.AtomationPracticePage
{
    public partial class AutomationPage : BasePage
    {
        public AutomationPage(IWebDriver driver)
            : base(driver, "automation-practice-switch-windows/", "toolsQAURL")
        {
        }
    }
}
