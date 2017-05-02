using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace DesignPatternsProject.Pages.SelectablePage
{
    public partial class SelectablePage
    {
        public IWebElement SelectItem1
        {
            get
            {
                return this.Driver.FindElement(By.XPath(".//*[@id='selectable']/li[1]"));
            }
        }
        public IWebElement SelectItem5
        {
            get
            {
                return this.Driver.FindElement(By.XPath(".//*[@id=\'selectable\']/li[5]"));
            }
        }
        public IWebElement GridSelectedItem6
        {
            get
            {
                return this.Driver.FindElement(By.XPath(".//*[@id='selectable_grid']/li[6]"));
            }
        }
        public IWebElement DisplayAsAGridButton
        {
            get
            {
                return this.Driver.FindElement(By.Id("ui-id-2"));
            }
        }
        public IWebElement SerializeButton
        {
            get
            {
                return this.Driver.FindElement(By.Id("ui-id-3"));
            }
        }
        public IWebElement SerializeItem3
        {
            get
            {
                return this.Driver.FindElement(By.XPath(".//*[@id=\'selectable-serialize\']/li[3]"));
            }
        }
        public IWebElement SelectedResult
        {
            get
            {
                return this.Driver.FindElement(By.Id("select-result"));
            }
        }
        public ReadOnlyCollection<IWebElement> MultipleSelected
            {
                get
                {
                    return this.Driver.FindElements(By.Id("select-result"));
                }
            }
        }

}
