using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace DesignPatternsProject.Pages.SortablePage
{
    public partial class SortablePage : BasePage
    {
        public SortablePage(IWebDriver driver)
            : base(driver, "sortable/", "demoQAURL")
        {
        }
    }
}
