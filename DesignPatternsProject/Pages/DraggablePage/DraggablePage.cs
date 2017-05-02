using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace DesignPatternsProject.Pages.DraggablePage
{
    public partial class DraggablePage : BasePage
    {
        public DraggablePage(IWebDriver driver)
            : base(driver, "draggable/", "demoQAURL")
        {
        }
    }
}
