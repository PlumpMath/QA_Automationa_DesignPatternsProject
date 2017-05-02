using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using DesignPatternsProject.Pages.HomePage;
using DesignPatternsProject.Pages.HomePage.RegistrationPage;
using DesignPatternsProject.Models;
using NUnit.Framework.Interfaces;
using System.Configuration;
using System.IO;
using OpenQA.Selenium.Chrome;

namespace SoftUniDesignPatternRegistration
{
    [TestFixture]
    public class TestClass
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
            if (TestContext.CurrentContext.Result.Outcome.Status ==TestStatus.Failed)
            {
                string path = ConfigurationManager.AppSettings["Logs"] +TestContext.CurrentContext.Test.Name + ".txt";
                File.WriteAllText(path, TestContext.CurrentContext.Test.FullName + "     " + TestContext.CurrentContext);

                var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                screenshot.SaveAsFile(ConfigurationManager.AppSettings["Logs"] + TestContext.CurrentContext.Test.Name + ".jpg",  ScreenshotImageFormat.Jpeg);
            }
            this.driver.Close();
        }
       

        public void NavigateToRegistrationPage()
        {
            HomePage homePage = new HomePage(this.driver);
            PageFactory.InitElements(driver, homePage);


            homePage.Navigate();

            Assert.AreEqual("Demoqa | Just another WordPress site", homePage.TagName);
        }


        [Test, Property("Priory", 3)]
        [Author("Neli Koynarska")]
        public void RegistrationWithoutMail()
        {
            RegistrationPage regPage = new RegistrationPage(this.driver);
            RegistrationUser user = ExcelDataAccess.GetTestData("withoutMail");
            regPage.Navigate();
            regPage.FillregistrationForm(user);
            regPage.AssertMessageForMail("* This field is required");
        }

        [Test, Property("Priory", 3)]
        [Author("Neli Koynarska")]
        public void RegistrationWithInvalidMail()
        {
            RegistrationPage regPage = new RegistrationPage(this.driver);
            RegistrationUser user = ExcelDataAccess.GetTestData("withInvalidMail");
            regPage.Navigate();
            regPage.FillregistrationForm(user);
            regPage.AssertMessageForInvalidMail("* Invalid email address");

        }

        [Test, Property("Priory", 2)]
        [Author("Neli Koynarska")]
        public void RegistrationWithoutLastUserName()
        {
            RegistrationPage regPage = new RegistrationPage(this.driver);
            RegistrationUser user = ExcelDataAccess.GetTestData("withoutLastUserName");
            regPage.Navigate();
            regPage.FillregistrationForm(user);
            regPage.AssertLastNamesErrorMessage("* This field is required");

            }
        [Test, Property("Priory", 2)]
        [Author("Neli Koynarska")]
        public void RegistrationWithoutFirstName()
        {
            RegistrationPage regPage = new RegistrationPage(this.driver);
            RegistrationUser user = ExcelDataAccess.GetTestData("withoutFirstUserName");
            regPage.Navigate();
            regPage.FillregistrationForm(user);
            regPage.AssertFirstNameErrorMessage("* This field is required");

            }
            [Test, Property("Priory", 2)]
            [Author("Neli Koynarska")]
            public void RegistrationWithoutPhone()
            {
                RegistrationPage regPage = new RegistrationPage(this.driver);
                RegistrationUser user = ExcelDataAccess.GetTestData("withoutPhoneNumber");
                regPage.Navigate();
                regPage.FillregistrationForm(user);
                regPage.AssertPhoneErrorMessage("* This field is required");

            }
            [Test, Property("Priory", 1)]
            [Author("Neli Koynarska")]
            public void RegistrationWithoutPassword()
            {
                RegistrationPage regPage = new RegistrationPage(this.driver);
                RegistrationUser user = ExcelDataAccess.GetTestData("withoutPassword");
                regPage.Navigate();
                regPage.FillregistrationForm(user);
                regPage.AssertPasswordErrorMessage("* This field is required");

            }
            [Test, Property("Priory", 1)]
            [Author("Neli Koynarska")]
            public void RegistrationWithoutConfirmPassword()
            {
                RegistrationPage regPage = new RegistrationPage(this.driver);
                RegistrationUser user = ExcelDataAccess.GetTestData("withoutConfirmPassword");
                regPage.Navigate();
                regPage.FillregistrationForm(user);
                regPage.AssertConfirmPasswordErrorMessage("* This field is required");
            }
            [Test, Property("Priory", 1)]
            [Author("Neli Koynarska")]
            public void RegistrationWithShortPassword()
            {
                RegistrationPage regPage = new RegistrationPage(this.driver);
                RegistrationUser user = ExcelDataAccess.GetTestData("withShortPassword");
                regPage.Navigate();
                regPage.FillregistrationForm(user);
                regPage.AssertShortPassErrorMessage("* Minimum 8 characters required");
            }
            [Test, Property("Priory", 1)]
            [Author("Neli Koynarska")]
            public void RegistrationPasswordDoesNotMatch()
            {
                RegistrationPage regPage = new RegistrationPage(this.driver);
                RegistrationUser user = ExcelDataAccess.GetTestData("PasswordDoesNotMatch");
                regPage.Navigate();
                regPage.FillregistrationForm(user);
                regPage.AssertPassDoesnNotMatchMessage("* Fields do not match");
            }
            [Test, Property("Priory", 2)]
            [Author("Neli Koynarska")]
            public void RegistrationWithWrongPhoneNumber()
            {
                RegistrationPage regPage = new RegistrationPage(this.driver);
                RegistrationUser user = ExcelDataAccess.GetTestData("withWrongPhoneNumber");
                regPage.Navigate();
                regPage.FillregistrationForm(user);
                regPage.AssertPhoneErrorMessage("* Minimum 10 Digits starting with Country Code");
            }
            [Test, Property("Priory", 2)]
            [Author("Neli Koynarska")]
            public void RegistrationWithoutHobbies()
            {
                RegistrationPage regPage = new RegistrationPage(this.driver);
                RegistrationUser user = ExcelDataAccess.GetTestData("withoutHobbies");
                regPage.Navigate();
                regPage.FillregistrationForm(user);
                regPage.AssertHobbiesErrorMessage("* This field is required");
            }
            [Test, Property("Priory", 2)]
            [Author("Neli Koynarska")]
            public void RegistrationWithoutMaritalSatus()
            {
                RegistrationPage regPage = new RegistrationPage(this.driver);
                RegistrationUser user = ExcelDataAccess.GetTestData("withoutMaritalStatus");
                regPage.Navigate();
                regPage.FillregistrationForm(user);
                regPage.AssertExistUserErrorMessage("Error: Username already exists");
            }
            [Test, Property("Priory", 1)]
            [Author("Neli Koynarska")]
            public void RegistrationExistUser()
            {
                RegistrationPage regPage = new RegistrationPage(this.driver);
                RegistrationUser user = ExcelDataAccess.GetTestData("withExistUser");
                regPage.Navigate();
                regPage.FillregistrationForm(user);
                regPage.AssertExistUserErrorMessage("Error: Username already exists");
            }
            [Test, Property("Priory", 1)]
            [Author("Neli Koynarska")]
            public void RegistrationWithInvalidPicture()
            {
                RegistrationPage regPage = new RegistrationPage(this.driver);
                RegistrationUser user = ExcelDataAccess.GetTestData("withInvalidPicture");
                regPage.Navigate();
                regPage.FillregistrationForm(user);
                regPage.AssertWithInvalidPicture("* Invalid File");
            }

            [Test, Property("Priory", 1)]
            [Author("Neli Koynarska")]
            public void RegisterWithBlankFields()
            {
                RegistrationPage regPage = new RegistrationPage(this.driver);
                RegistrationUser user = ExcelDataAccess.GetTestData("withInvalidPicture");
                regPage.Navigate();
                regPage.Submit.Click();
                regPage.AssertLastNamesErrorMessage("* This field is required");
                regPage.AssertHobbiesErrorMessage("* This field is required");
                regPage.AssertPhoneErrorMessage("* This field is required");
                regPage.AssertMessageForMail("* This field is required");
                regPage.AssertPasswordErrorMessage("* This field is required");
                regPage.AssertConfirmPasswordErrorMessage("* This field is required");
            }

        }
    }



