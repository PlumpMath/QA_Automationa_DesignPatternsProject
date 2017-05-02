using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace DesignPatternsProject.Pages.ResiblePage
{
    public partial class ResizablePage:BasePage
    {
        public ResizablePage(IWebDriver driver)
            : base(driver, "resizable/", "demoQAURL")
        {
        }
    }
}
