using System.Linq;
using System.Threading;
using DesignPatternsProject.Pages.AtomationPracticePage;
using DesignPatternsProject.Pages.DraggablePage;
using DesignPatternsProject.Pages.DroppablePage;
using DesignPatternsProject.Pages.ResiblePage;
using DesignPatternsProject.Pages.SelectablePage;
using DesignPatternsProject.Pages.SortablePage;
using DesignPatternsProject.Pages.ToolsQAHomePage;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Chrome;

namespace DesignPatternsProject
{
    [TestFixture]
    public class ToolsQATests
    {
        private IWebDriver driver;
        
        [SetUp]
        public void TestSetUp()
        {
            //this.driver = new FirefoxDriver();
            this.driver = new ChromeDriver();
        }

        [TearDown]
        public void CleanUp()
        {
            this.driver.Quit();
        }

        [Test, Property("Priory", 3)]
        [Author("Neli Koynarska")]
        public void HandlePopUp()
        {
            var automationPage = new AutomationPage(this.driver);
            var homePage = new ToolsQAHomePage(this.driver);
            automationPage.Navigate();
            string firstTab = this.driver.WindowHandles.First();
            automationPage.NewTabButton.Click();
            string secondTab = this.driver.WindowHandles.Last();
            this.driver.SwitchTo().Window(secondTab);
            homePage.AssertLogoSrc("http://20tvni1sjxyh352kld2lslvc.wpengine.netdna-cdn.com/wp-content/uploads/2014/08/Toolsqa.jpg");
            automationPage.AssertCountTabs(2);

        }

        [Test, Property("Priory", 3)]
        [Author("Neli Koynarska")]
        public void DroppableFirst()
        {

            var droppablePage = new DroppablePage(this.driver);
            Actions builder = new Actions(this.driver);
            droppablePage.Navigate();
            var drag = builder.DragAndDrop(droppablePage.Source, droppablePage.Target);
            drag.Perform();
            droppablePage.AssertChangeColorBox("ui-widget-header ui-droppable ui-state-highlight");

        }
        [Test, Property("Priory", 3)]
        [Author("Neli Koynarska")]
        public void DroppableUnAcceptBox()
        {

            var droppablePage = new DroppablePage(this.driver);
            Actions builder = new Actions(this.driver);
            droppablePage.Navigate();
            droppablePage.AcceptButton.Click();
            var drag = builder.DragAndDrop(droppablePage.NonValidBox, droppablePage.AcceptBox);
            drag.Perform();
            droppablePage.AssertNonChangeBox("ui-widget-header ui-droppable");
        }

        [Test, Property("Priory", 3)]
        [Author("Neli Koynarska")]
        public void DroppableRevertBox()
        {
            var droppablePage = new DroppablePage(this.driver);
            Actions builder = new Actions(this.driver);
            droppablePage.Navigate();
            droppablePage.RevertButton.Click();
            var beforeLocation = droppablePage.RevertBox.Location;
            var drag = builder.DragAndDrop(droppablePage.RevertBox, droppablePage.DroppRevertBox);
            drag.Perform();
            Thread.Sleep(5000);
            droppablePage.AsserRevertBoxIsReverted(beforeLocation);
        }

        [Test, Property("Priory", 3)]
        [Author("Neli Koynarska")]
        public void PreventBoxesAreColored()
        {
            var droppablePage = new DroppablePage(this.driver);
            Actions builder = new Actions(this.driver);
            droppablePage.Navigate();
            droppablePage.PreventButton.Click();
            var drag = builder.DragAndDrop(droppablePage.DraggMeBox, droppablePage.FirstInnerDroppableBox);
            drag.Perform();
            droppablePage.AssertBothBoxesAreColoredEqually();
        }

        [Test, Property("Priory", 3)]
        [Author("Neli Koynarska")]
        public void PreventBoxesAreNotColored()
        {
            var droppablePage = new DroppablePage(this.driver);
            Actions builder = new Actions(this.driver);
            droppablePage.Navigate();
            droppablePage.PreventButton.Click();
            var drag = builder.DragAndDrop(droppablePage.DraggMeBox, droppablePage.SecondInnerDroppableBox);
            drag.Perform();
            droppablePage.AssertBothBoxesAreNotColoredEqually();
        }
        [Test, Property("Priory", 3)]
        [Author("Neli Koynarska")]
        public void ResizableWindowLimited()
        {
            var resizablePage = new ResizablePage(this.driver);
            Actions builder = new Actions(this.driver);
            resizablePage.Navigate();
            resizablePage.ConstResizableButton.Click();
            builder.DragAndDropToOffset(resizablePage.ResizableButon, 110, 110).Perform();
            resizablePage.AssertResizableButtonXY(445, 510);
        }
        [Test, Property("Priory", 3)]
        [Author("Neli Koynarska")]
        public void HelperResizableTest()
        {
            var resizablePage = new ResizablePage(this.driver);
            Actions builder = new Actions(this.driver);
            resizablePage.Navigate();
            resizablePage.HelperResizableButton.Click();
            int width = resizablePage.ResizeWindow.Size.Width;
            int height = resizablePage.ResizeWindow.Size.Height;
            builder.DragAndDropToOffset(resizablePage.ResizableButon1, 100, 100).Perform();
            resizablePage.AssertHelperResizableWindowBiggerThan(width + 90, height + 90);


        }
        [Test, Property("Priory", 3)]
        [Author("Neli Koynarska")]
        public void DraggablePageFirstTest()
        {
            var draggablePage = new DraggablePage(this.driver);
            Actions builder = new Actions(this.driver);
            draggablePage.Navigate();
            var beforelocation = draggablePage.DragMeBox.Location;
            builder.DragAndDrop(draggablePage.DragMeBox, draggablePage.InsideBox);
            builder.Perform();
            draggablePage.AssertBoxPositionNotEqual(beforelocation);

        }
        [Test, Property("Priory", 3)]
        [Author("Neli Koynarska")]
        public void DraggablePageMovementOnlyHorrizontally()
        {
            var draggablePage = new DraggablePage(this.driver);
            Actions builder = new Actions(this.driver);
            draggablePage.Navigate();
            draggablePage.ConstrainMovementButton.Click();
            var beforeYlocation = draggablePage.HorryzontallyMovementBox.Location.Y;
            builder.DragAndDrop(draggablePage.HorryzontallyMovementBox, draggablePage.AnotherDomBox);
            builder.Perform();
            draggablePage.AssertMovementHorrizontally(beforeYlocation);

        }
        [Test, Property("Priory", 3)]
        [Author("Neli Koynarska")]
        public void DraggablePageMovementOnlyVertically()
        {
            var draggablePage = new DraggablePage(this.driver);
            Actions builder = new Actions(this.driver);
            draggablePage.Navigate();
            draggablePage.ConstrainMovementButton.Click();
            var beforeXlocation = draggablePage.VerticallyMovementBox.Location.X;
            builder.DragAndDrop(draggablePage.VerticallyMovementBox, draggablePage.AnotherDomBox);
            builder.Perform();
            draggablePage.AssertMovementVertically(beforeXlocation);

        }
        [Test, Property("Priory", 3)]
        [Author("Neli Koynarska")]
        public void DraggablePageNonMovementBox()
        {
            var draggablePage = new DraggablePage(this.driver);
            Actions builder = new Actions(this.driver);
            draggablePage.Navigate();
            draggablePage.ConstrainMovementButton.Click();
            var beforelocation = draggablePage.NonMovementBox.Location.X;// It's should be the same with Y location,
            builder.DragAndDrop(draggablePage.NonMovementBox, draggablePage.AnotherDomBox);//but there is a small movement because of the text
            builder.Perform();
            draggablePage.AssertNonMovementBox(beforelocation);

        }
        [Test, Property("Priory", 3)]
        [Author("Neli Koynarska")]
        public void DraggablePageMovementWithintheBox()
        {
            var draggablePage = new DraggablePage(this.driver);
            Actions builder = new Actions(this.driver);
            draggablePage.Navigate();
            draggablePage.ConstrainMovementButton.Click();
            builder.DragAndDrop(draggablePage.MovementwitihtheBox, draggablePage.MainBox);
            builder.Perform();
            draggablePage.AssertMovementWithintheBox(draggablePage.MovementwitihtheBox, draggablePage.AnotherDomBox);
        }

        [Test, Property("Priory", 3)]
        [Author("Neli Koynarska")]
        public void SelectableFirstItem()
        {

            var selectablePage = new SelectablePage(this.driver);
            Actions builder = new Actions(this.driver);
            selectablePage.Navigate();
            selectablePage.SelectItem1.Click();
            selectablePage.AssertSelectedItemClass("ui-widget-content ui-corner-left ui-selectee ui-selected");

        }
        [Test, Property("Priory", 3)]
        [Author("Neli Koynarska")]
        public void SelectableGridItem()
        {

            var selectablePage = new SelectablePage(this.driver);
            Actions builder = new Actions(this.driver);
            selectablePage.Navigate();
            selectablePage.DisplayAsAGridButton.Click();
            selectablePage.GridSelectedItem6.Click();
            selectablePage.AssertSelectedGridItem6Class("ui-state-default ui-corner-left ui-selectee ui-selected");

        }
        [Test, Property("Priory", 3)]
        [Author("Neli Koynarska")]
        public void SelectedItemAndResultAreTheSame()
        {

            var selectablePage = new SelectablePage(this.driver);
            Actions builder = new Actions(this.driver);
            selectablePage.Navigate();
            selectablePage.SerializeButton.Click();
            selectablePage.SerializeItem3.Click();
            selectablePage.AssertSelectedResultEquals("#3");

        }

        [Test, Property("Priory", 3)]
        [Author("Neli Koynarska")]
        public void SortableItemsOrder()
        {
            var sortablePage = new SortablePage(this.driver);
            Actions builder = new Actions(this.driver);
            sortablePage.Navigate();
            // We drop the item over 6 but in fact it is positioned just before that
            builder.DragAndDrop(sortablePage.FirstItem, sortablePage.SixthItem);
            builder.Perform();
            sortablePage.AssertItemText(4, "Item 1");
        }

        [Test, Property("Priory", 3)]
        [Author("Neli Koynarska")]
        public void MoveItemFromListToList()
        {
            var sortablePage = new SortablePage(this.driver);
            Actions builder = new Actions(this.driver);
            sortablePage.Navigate();
            sortablePage.ConnectListBtn.Click();
            builder.DragAndDrop(sortablePage.ItemsList1, sortablePage.ItemsList2);
            builder.Perform();
            sortablePage.AssertItemLengthInLists(4, 6);

            builder.DragAndDrop(sortablePage.ItemsList1, sortablePage.ItemsList2);
            builder.Perform();
            builder.DragAndDrop(sortablePage.ItemsList1, sortablePage.ItemsList2);
            builder.Perform();
            builder.DragAndDrop(sortablePage.ItemsList1, sortablePage.ItemsList2);
            builder.Perform();
            builder.DragAndDrop(sortablePage.ItemsList1, sortablePage.ItemsList2);
            builder.Perform();

            sortablePage.AssertItemLengthInLists(0, 10);
        }
        [Test, Property("Priory", 3)]
        [Author("Neli Koynarska")]
        public void SortableGridItemsAreSorted()
        {
            var sortablePage = new SortablePage(this.driver);
            Actions builder = new Actions(this.driver);
            sortablePage.Navigate();
            sortablePage.DesplayAsGridBtn.Click();
            builder.DragAndDrop(sortablePage.ItemsGrid1, sortablePage.ItemsGrid7);
            builder.Perform();
            sortablePage.AssertGridItemText(5, "1");
        }
        //[Test, Property("Priory", 3)]
        //[Author("Neli Koynarska")]
        //public void MuntilpleSelectedItems()
        //{

        //    var selectablePage = new SelectablePage(this.driver);
        //    Actions builder = new Actions(this.driver);
        //    selectablePage.Navigate();
        //    //selectablePage.SelectItem1.Click();
        //    builder.DragAndDrop(selectablePage.SelectItem1, selectablePage.SelectItem5);
        //    builder.Perform();
        //    selectablePage.AssertMultipleSelected(5);

        //}
    }
}

