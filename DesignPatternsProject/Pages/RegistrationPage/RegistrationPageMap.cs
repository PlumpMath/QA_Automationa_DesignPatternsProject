using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DesignPatternsProject.Pages.HomePage.RegistrationPage
{
    public partial class RegistrationPage
    {
        public IWebElement FirstName
        {
            get
            {
                return Driver.FindElement(By.Id("name_3_firstname"));
            }
        }
        public IWebElement LastName
        {
            get
            {
                return Driver.FindElement(By.Id("name_3_lastname"));
            }
        }
        public List<IWebElement> MaritalStatus
        {
            get
            {
                return Driver.FindElements(By.XPath(".//*[@id=\'pie_register\']/li[2]/div/div/input[1]")).ToList();
            }
        }
        public List<IWebElement> hobbies
        {
            get
            {
                return Driver.FindElements(By.Name("checkbox_5[]")).ToList();
            }
        }
        private IWebElement Country
        {
            get
            {
                return Driver.FindElement(By.Id("dropdown_7"));
            }
        }
        public SelectElement countryOption
        {
            get
            {
                return new SelectElement(Country);
            }
        }
        private IWebElement MonthOfBirth
        {
            get
            {
                return Driver.FindElement(By.Id("mm_date_8"));
            }
        }
        public SelectElement MonthOfBirthOptions
        {
            get
            {
                return new SelectElement(MonthOfBirth);
            }
        }

        private IWebElement DateOfBirth
        {
            get
            {
                return Driver.FindElement(By.Id("dd_date_8"));
            }
        }
        public SelectElement DateOfBirthOptions
        {
            get
            {
                return new SelectElement(DateOfBirth);
            }
        }
        private IWebElement YearOfBirth
        {
            get
            {
                return Driver.FindElement(By.Id("yy_date_8"));
            }
        }
        public SelectElement YearOfBirthOptions
        {
            get
            {
                return new SelectElement(YearOfBirth);
            }
        }
        private IWebElement PhoneNumber
        {
            get
            {
                return Driver.FindElement(By.Id("phone_9"));
            }
        }
        private IWebElement UserName
        {
            get
            {
                return Driver.FindElement(By.Id("username"));
            }
        }
        private IWebElement Email
        {
            get
            {
                return Driver.FindElement(By.Id("email_1"));
            }
        }
        private IWebElement Uploadphoto
        {
            get
            {
                return Driver.FindElement(By.Id("profile_pic_10"));
            }
        }
        private IWebElement Description
        {
            get
            {
                return Driver.FindElement(By.Id("description"));
            }
        }
        private IWebElement Password
        {
            get
            {
                return Driver.FindElement(By.Id("password_2"));
            }
        }
        private IWebElement ConfirmPassword
        {
            get
            {
                return Driver.FindElement(By.Id("confirm_password_password_2"));
            }
        }
        public IWebElement Submit
        {
            get
            {
                return Driver.FindElement(By.Name("pie_submit"));
            }
        }
        public IWebElement SuccessMessage
        {
            get
            {
                return this.Driver.FindElement(By.ClassName("piereg_message"));
            }
        }
        public IWebElement ErrorMessageForMail
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(".//*[@id=\'pie_register\']/li[8]/div/div/span")));
                return this.Driver.FindElement(By.XPath(".//*[@id=\'pie_register\']/li[8]/div/div/span"));
            }
        }
        public IWebElement ErrorMessageWithoutFirstName
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(".//*[@id=\'pie_register\']/li[1]/div[1]/div[2]/span")));
                return this.Driver.FindElement(By.XPath(".//*[@id=\'pie_register\']/li[1]/div[1]/div[2]/span"));
            }
        }
        public IWebElement ErrorMessageWithoutLastName
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(".//*[@id=\'pie_register\']/li[1]/div[1]/div[2]/span")));
                return this.Driver.FindElement(By.XPath(".//*[@id=\'pie_register\']/li[1]/div[1]/div[2]/span"));
            }
        }
        public IWebElement ErrorMessageWithoutHobbies
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(".//*[@id=\'pie_register\']/li[3]/div/div[2]/span")));
                return this.Driver.FindElement(By.XPath(".//*[@id=\'pie_register\']/li[3]/div/div[2]/span"));
            }
        }
        public IWebElement ErrorMessageWithoutPhone
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(".//*[@id=\'pie_register\']/li[6]/div/div/span")));
                return this.Driver.FindElement(By.XPath(".//*[@id=\'pie_register\']/li[6]/div/div/span"));
            }
        }
        public IWebElement ErrorMessageWithoutUserName
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(".//*[@id=\'pie_register\']/li[7]/div/div/span")));
                return this.Driver.FindElement(By.XPath(".//*[@id=\'pie_register\']/li[7]/div/div/span"));
            }
        }
        public IWebElement ErrorMessageWithoutPassword
        {
            get
            {                                                             
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(".//*[@id=\'pie_register\']/li[11]/div/div/span")));
                return this.Driver.FindElement(By.XPath(".//*[@id=\'pie_register\']/li[11]/div/div/span"));
            }
        }
        public IWebElement ErrorMessageWithoutConfirmPass
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(".//*[@id=\'pie_register\']/li[12]/div/div/span")));
                return this.Driver.FindElement(By.XPath(".//*[@id=\'pie_register\']/li[12]/div/div/span"));
            }
        } 
        public IWebElement ErrorMessageWitIncorectPicture
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(".//*[@id=\'pie_register\']/li[9]/div/div/span")));
                return this.Driver.FindElement(By.XPath(".//*[@id=\'pie_register\']/li[9]/div/div/span"));
            }
        }
        public IWebElement ErrorMessageExistUser
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(".//*[@id=\'post-49\']/div/p")));
                return this.Driver.FindElement(By.XPath(".//*[@id=\'post-49\']/div/p"));//.//*[@id='post-49']/div/p
            }
        }
        public IWebElement ErrorMessageInvalidEmail
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(".//*[@id=\'pie_register\']/li[8]/div/div/span")));
                return this.Driver.FindElement(By.XPath(".//*[@id=\'pie_register\']/li[8]/div/div/span"));
            }
        }
        public IWebElement ErrorMessageShortPassword
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(".//*[@id=\'pie_register\']/li[11]/div/div/span")));
                return this.Driver.FindElement(By.XPath(".//*[@id=\'pie_register\']/li[11]/div/div/span"));
            }
        }
        public IWebElement ErrorMessagePasswordDoesNotMatch
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(".//*[@id='pie_register']/li[12]/div/div/span")));
                return this.Driver.FindElement(By.XPath(".//*[@id='pie_register']/li[12]/div/div/span"));
            }
        }
        public IWebElement ErrorMessageWrongPhone
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(".//*[@id=\'pie_register\']/li[6]/div/div/span")));
                return this.Driver.FindElement(By.XPath(".//*[@id=\'pie_register\']/li[6]/div/div/span"));
            }
        }
    }

}
