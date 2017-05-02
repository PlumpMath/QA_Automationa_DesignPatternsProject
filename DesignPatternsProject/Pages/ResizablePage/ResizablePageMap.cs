using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace DesignPatternsProject.Pages.ResiblePage
{
    public partial class ResizablePage
    {
        public IWebElement ConstResizableButton 
        {
            get 
            {
                return this.Driver.FindElement(By.Id("ui-id-3"));
            }
        }
        public IWebElement ResizableButon
        {
            get
            {
                return this.Driver.FindElement(By.XPath(".//*[@id=\'resizableconstrain\']/div[3]"));
            }
        }
        public IWebElement ResizableButon1
        {
            get
            {
                return this.Driver.FindElement(By.XPath(".//*[@id=\'resizable_helper\']/div[3]"));
            }
        }
        public IWebElement ContaintmentBox
        {
            get
            {
                return this.Driver.FindElement(By.Id("container1"));
            }
        }
        public IWebElement HelperResizableButton
        {
            get
            {
                return this.Driver.FindElement(By.Id("ui-id-4"));
            }
        }
        public IWebElement ResizeWindow
        {
            get
            {
                return this.Driver.FindElement(By.Id("resizable_helper"));
            }
        }
    }
}
