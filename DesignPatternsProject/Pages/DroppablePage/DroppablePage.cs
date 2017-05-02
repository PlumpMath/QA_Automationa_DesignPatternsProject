using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace DesignPatternsProject.Pages.DroppablePage
{
    public partial class DroppablePage : BasePage
    {
        public DroppablePage(IWebDriver driver)
            : base(driver, "droppable/", "demoQAURL")
        {
        }
    }
}
