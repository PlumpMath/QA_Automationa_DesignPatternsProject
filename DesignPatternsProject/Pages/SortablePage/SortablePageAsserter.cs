using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DesignPatternsProject.Pages.SortablePage
{
    public static class SortablePageAsserter
    {
        public static void AssertItemText(this SortablePage page, int index, string text)
        {
            Assert.AreEqual(page.ContainerItems[index].Text, text);
        }

        public static void AssertItemLengthInLists(this SortablePage page, int legnthList1, int legnthList2)
        {
            Assert.AreEqual(page.ContainerItemsList1.Count, legnthList1);
            Assert.AreEqual(page.ContainerItemsList2.Count, legnthList2);
        }
        public static void AssertGridItemText(this SortablePage page, int index, string text)
        {
            Assert.AreEqual(page.ContainerGridItems[index].Text, text);
        }
    }
}
