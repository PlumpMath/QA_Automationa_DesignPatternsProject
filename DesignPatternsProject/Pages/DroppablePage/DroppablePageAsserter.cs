using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DesignPatternsProject.Pages.DroppablePage
{
    public static class DroppablePageAsserter
    {
        public static void AssertChangeColorBox(this DroppablePage page, string text)
        {
            Assert.AreEqual(text, page.Target.GetAttribute("class"));  
        }

        public static void AssertNonChangeBox(this DroppablePage page, string text)
        {
            Assert.AreEqual(text, page.AcceptBox.GetAttribute("class"));
        }
        public static void AsserRevertBoxIsReverted(this DroppablePage page, Point location)
        {
            Assert.AreEqual(location, page.RevertBox.Location);
        }
        public static void AssertBothBoxesAreColoredEqually(this DroppablePage page)
        {
            Assert.AreEqual(page.OuterDroppableBoxColored.GetAttribute("class"), page.FirstInnerDroppableBox.GetAttribute("class"));
        }

        public static void AssertBothBoxesAreNotColoredEqually(this DroppablePage page)
        {
            Assert.AreEqual(page.OuterDroppableBoxUnColored.GetAttribute("class"), page.SecondInnerDroppableBox.GetAttribute("class"));
        }
    }
}
