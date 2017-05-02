using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace DesignPatternsProject.Pages.SelectablePage
{
    public static class SelectablePageAsserter
    {
        public static void AssertSelectedItemClass(this SelectablePage page, string text)
        {
            Assert.AreEqual(text, page.SelectItem1.GetAttribute("class"));
        }
        public static void AssertSelectedGridItem6Class(this SelectablePage page, string text)
        {
            Assert.AreEqual(text, page.GridSelectedItem6.GetAttribute("class"));
        }
        public static void AssertSelectedResultEquals(this SelectablePage page, string text)
        {
            Assert.AreEqual(text, page.SelectedResult.Text);
        }
        public static void AssertMultipleSelected(this SelectablePage page, string text1,string text2,string text3,string text4,string text5)
        {
            //Assert.AreEqual(text1, page.MultipleSelected.ToList<IWebElement>);
        }
    }
}
