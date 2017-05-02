using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace DesignPatternsProject.Pages.SortablePage
{
    public partial class SortablePage
    {
        public IWebElement FirstItem
        {
            get
            {
                return this.Driver.FindElement(By.XPath(".//*[@id=\'sortable\']/li[1]"));
            }
        }
        public IWebElement SixthItem
        {
            get
            {
                return this.Driver.FindElement(By.XPath(".//*[@id=\'sortable\']/li[6]"));
            }
        }
        public ReadOnlyCollection<IWebElement> ContainerItems
        {
            get
            {
                return this.Driver.FindElements(By.XPath(".//*[@id=\'sortable\']/li"));
            }
        }
        public ReadOnlyCollection<IWebElement> ContainerItemsList1
        {
            get
            {
                return this.Driver.FindElements(By.XPath(".//*[@id=\'sortable1\']/li"));
            }
        }
        public ReadOnlyCollection<IWebElement> ContainerItemsList2
        {
            get
            {
                return this.Driver.FindElements(By.XPath(".//*[@id=\'sortable2\']/li"));
            }
        }
        public IWebElement ItemsList1
        {
            get
            {                                           
                return this.Driver.FindElement(By.XPath(".//*[@id=\'sortable1\']/li[1]"));
            }
        }
        public IWebElement ItemsList2
        {
            get
            {
                return this.Driver.FindElement(By.XPath(".//*[@id=\'sortable2\']/li[1]"));
            }
        }
        public IWebElement ConnectListBtn
        {
            get
            {
                return this.Driver.FindElement(By.Id("ui-id-2"));
            }
        }
        public IWebElement DesplayAsGridBtn
        {
            get
            {
                return this.Driver.FindElement(By.Id("ui-id-3"));
            }
        }
        public IWebElement ItemsGrid1
        {
            get
            {
                return this.Driver.FindElement(By.XPath(".//*[@id=\'sortable_grid\']/li[1]"));
            }
        }
        public IWebElement ItemsGrid7
        {
            get
            {
                return this.Driver.FindElement(By.XPath(".//*[@id=\'sortable_grid\']/li[7]"));
            }
        }
        public ReadOnlyCollection<IWebElement> ContainerGridItems
        {
            get
            {
                return this.Driver.FindElements(By.XPath(".//*[@id=\'sortable_grid\']/li"));
            }
        }
    }
}
