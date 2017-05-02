using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DesignPatternsProject.Pages.AtomationPracticePage
{
    public static  class AutomationPageAsserter
    {
        public static void AssertCountTabs(this AutomationPage page, int count)
        {
            Assert.AreEqual(count, page.Driver.WindowHandles.Count);
        }
    }
}
