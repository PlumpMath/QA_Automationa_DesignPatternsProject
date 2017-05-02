using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace DesignPatternsProject.Pages.SelectablePage
{
    public partial class SelectablePage : BasePage
    {
        public SelectablePage(IWebDriver driver)
            : base(driver, "selectable/", "demoQAURL")
        {
        }
    }
}
