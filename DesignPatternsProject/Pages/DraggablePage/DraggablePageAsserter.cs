using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace DesignPatternsProject.Pages.DraggablePage
{
    public static class DraggablePageAsserter
    {
        public static void AssertBoxPositionNotEqual(this DraggablePage page, Point p)
        {
            Assert.AreNotEqual(p, page.DragMeBox.Location);
        }
        public static void AssertMovementHorrizontally(this DraggablePage page, int ylocation)
        {
            Assert.AreEqual(ylocation, page.HorryzontallyMovementBox.Location.Y);
        }
        public static void AssertMovementVertically(this DraggablePage page, int xlocation)
        {
            Assert.AreEqual(xlocation, page.VerticallyMovementBox.Location.X);
        }
        public static void AssertNonMovementBox(this DraggablePage page, int xlocation)
        {
            Assert.AreEqual(xlocation, page.NonMovementBox.Location.X);
        }
        public static void AssertMovementWithintheBox(this DraggablePage page, IWebElement inner, IWebElement outer)
        {
            Assert.Greater(  inner.Location.X - (inner.Size.Width / 2), outer.Location.X - (outer.Size.Width /2) );
            Assert.Greater(  inner.Location.Y - (inner.Size.Height / 2), outer.Location.Y - (outer.Size.Height /2) );
        }
    }
}
