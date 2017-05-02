using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace DesignPatternsProject.Pages.DroppablePage
{
    public partial class DroppablePage
    {
        public IWebElement Source
        {
            get
            {
                return this.Driver.FindElement(By.XPath(".//*[@id=\'draggableview\']/p"));

            }
        }
        public IWebElement Target
        {
            get
            {
                return this.Driver.FindElement(By.Id("droppableview"));

            }
        }
        public IWebElement AcceptButton
        {
            get
            {
                return this.Driver.FindElement(By.Id("ui-id-2"));

            }
        }
        public IWebElement NonValidBox
        {
            get
            {
                return this.Driver.FindElement(By.XPath(".//*[@id=\'draggable-nonvalid\']/p"));

            }
        }
        public IWebElement ValidBox
        {
            get
            {
                return this.Driver.FindElement(By.XPath(".//*[@id=\'draggableaccept\']/p"));

            }
        }
        public IWebElement AcceptBox
        {
            get
            {
                return this.Driver.FindElement(By.XPath(".//*[@id=\'droppableaccept\']"));

            }
        }
        public IWebElement RevertButton
        {
            get
            {
                return this.Driver.FindElement(By.Id("ui-id-4"));

            }
        }
        public IWebElement RevertBox
        {
            get
            {
                return this.Driver.FindElement(By.XPath(".//*[@id=\'draggablerevert\']/p"));

            }
        }
        public IWebElement DroppRevertBox
        {
            get
            {
                return this.Driver.FindElement(By.Id("droppablerevert"));

            }
        }
        public IWebElement UnRevertBox
        {
            get
            {
                return this.Driver.FindElement(By.XPath(".//*[@id=\'draggablerevert2\']/p"));

            }
        }
        public IWebElement PreventButton
        {
            get
            {
                return this.Driver.FindElement(By.Id("ui-id-3"));

            }
        }
        public IWebElement DraggMeBox
        {
            get
            {
                return this.Driver.FindElement(By.XPath(".//*[@id=\'draggableprop\']/p"));

            }
        }
        public IWebElement OuterDroppableBoxColored
        {
            get
            {
                return this.Driver.FindElement(By.XPath(".//*[@id='droppableprop']/p"));

            }
        }

        public IWebElement OuterDroppableBoxUnColored
        {
            get
            {
                return this.Driver.FindElement(By.XPath(".//*[@id=\'droppableprop2\']/p"));

            }
        }
        public IWebElement FirstInnerDroppableBox
        {
            get
            {
                return this.Driver.FindElement(By.XPath(".//*[@id=\'droppable-inner\']/p"));

            }
        }
        public IWebElement SecondInnerDroppableBox
        {
            get
            {
                return this.Driver.FindElement(By.XPath(".//*[@id=\'droppable2-inner\']/p"));
            }
        }
       
    }
}
