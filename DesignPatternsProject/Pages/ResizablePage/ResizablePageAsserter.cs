using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DesignPatternsProject.Pages.ResiblePage
{
    public static class ResizablePageAsserter
    {

        public static void AssertResizableButtonXY(this ResizablePage page, int x, int y)
        {
            Assert.AreEqual(page.ResizableButon.Location.X, x);
            Assert.AreEqual(page.ResizableButon.Location.Y, y);
        }
        public static void AssertHelperResizableWindowBiggerThan(this ResizablePage page, int width, int heigh)
        {
            Assert.Greater(page.ResizeWindow.Size.Width, width );
            Assert.Greater(page.ResizeWindow.Size.Height, heigh);
        }
    }
}
