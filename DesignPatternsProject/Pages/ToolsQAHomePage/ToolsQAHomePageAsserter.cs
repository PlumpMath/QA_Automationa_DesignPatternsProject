using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DesignPatternsProject.Pages.ToolsQAHomePage
{
    public static class ToolsQAHomePageAsserter
    {
        public static void AssertLogoSrc(this ToolsQAHomePage page, string text)
        {
            Assert.AreEqual(text,page.Logo.GetAttribute("src"));
        }
    }
}
