using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsProject.Models;
using OpenQA.Selenium;

namespace DesignPatternsProject.Pages.HomePage.RegistrationPage
{
    public partial class RegistrationPage : BasePage
    {
        public RegistrationPage(IWebDriver driver)
            : base(driver, "registration/", "demoQAURL")
        {
        }

        public void FillregistrationForm(RegistrationUser user)
        {
            Type(this.FirstName, user.FirstName);
            Type(this.LastName, user.LastName);
            ClickOnElements(this.MaritalStatus, user.MaritalStatus);
            ClickOnElements(this.hobbies, user.Hobbies);
            this.countryOption.SelectByText(user.Country);
            this.MonthOfBirthOptions.SelectByText(user.BirthMonth);
            this.DateOfBirthOptions.SelectByText(user.BirthDay);
            this.YearOfBirthOptions.SelectByText(user.BirthYear);
            Type(this.PhoneNumber, user.PhoneNumber);
            Type(this.UserName, user.UserName);
            Type(this.Email, user.Email);
            this.Uploadphoto.Click();
            this.Driver.SwitchTo().ActiveElement().SendKeys(user.Picture);
            Type(this.Description, user.Description);
            Type(this.Password, user.Password);
            Type(this.ConfirmPassword, user.ConfirmPassword);
            this.Submit.Click();
        }

        private void ClickOnElements(List<IWebElement> maritalStatus, string list)
        {
            string[] listAsArray = list.Split(','); // "1,1,0" -> ['1', '1', '0']

            for (int i = 0; i < listAsArray.Length; i++)
                if (listAsArray[i] == "1")
                {
                    maritalStatus[i].Click();
                }
        }
    
        public void Type(IWebElement element, string text)
        {
            if (text != null)
            {
                element.Clear();
                element.SendKeys(text);
            }
        }
    }
}
