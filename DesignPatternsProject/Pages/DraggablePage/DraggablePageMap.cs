using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace DesignPatternsProject.Pages.DraggablePage
{
    public partial class DraggablePage
    {
        public IWebElement DragMeBox
        {
            get
            {
                return this.Driver.FindElement(By.Id("draggable"));

            }
        }
        public IWebElement InsideBox
        {
            get
            {
                return this.Driver.FindElement(By.XPath(".//*[@id='tabs-1']/div"));

            }
        }
        public IWebElement AnotherDomBox
        {
            get
            {
                return this.Driver.FindElement(By.Id("containment-wrapper"));

            }
        }
        public IWebElement ConstrainMovementButton
        {
            get
            {
                return this.Driver.FindElement(By.Id("ui-id-2"));

            }//.//*[@id='draggabl2']/p
        }
        public IWebElement HorryzontallyMovementBox
        {
            get
            {
                return this.Driver.FindElement(By.XPath(".//*[@id=\'draggabl2\']/p"));

            }
        }
        public IWebElement VerticallyMovementBox
        {
            get
            {
                return this.Driver.FindElement(By.XPath(".//*[@id=\'draggabl\']/p"));

            }
        }
        public IWebElement NonMovementBox
        {
            get
            {
                return this.Driver.FindElement(By.Id("draggabl5"));

            }
        }
        public IWebElement MovementwitihtheBox
        {
            get
            {
                return this.Driver.FindElement(By.XPath(".//*[@id='draggabl3']/p"));

            }
        }
        public IWebElement MainBox
        {
            get
            {
                return this.Driver.FindElement(By.XPath(".//*[@id=\'tabs-3\']/div"));

            }
        }
    }
}
