using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Pages.HomePage.RegistrationPage
{
    public static class RegistrationPageAsserter
    {

        public static void AssesrtSuccessMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.SuccessMessage.Displayed);
            Assert.AreEqual(text, page.SuccessMessage.Text);
        }
        public static void AssertMessageForMail(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForMail.Displayed);
            Assert.AreEqual(text, page.ErrorMessageForMail.Text);
        }
        public static void AssertMessageForInvalidMail(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageInvalidEmail.Displayed);
            Assert.AreEqual(text, page.ErrorMessageInvalidEmail.Text);
        }

        public static void AssertFirstNameErrorMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageWithoutFirstName.Displayed);
            StringAssert.Contains(text, page.ErrorMessageWithoutFirstName.Text);
        }
        public static void AssertLastNamesErrorMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageWithoutLastName.Displayed);
            StringAssert.Contains(text, page.ErrorMessageWithoutLastName.Text);
        }

        public static void AssertPhoneErrorMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageWithoutPhone.Displayed);
            StringAssert.Contains(text, page.ErrorMessageWithoutPhone.Text);
        }
        public static void AssertHobbiesErrorMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageWithoutHobbies.Displayed);
            StringAssert.Contains(text, page.ErrorMessageWithoutHobbies.Text);
        }
        public static void AssertUserNameErrorMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageWithoutUserName.Displayed);
            StringAssert.Contains(text, page.ErrorMessageWithoutUserName.Text);
        }
        public static void AssertPasswordErrorMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageWithoutPassword.Displayed);
            StringAssert.Contains(text, page.ErrorMessageWithoutPassword.Text);
        }
        public static void AssertConfirmPasswordErrorMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageWithoutConfirmPass.Displayed);
            StringAssert.Contains(text, page.ErrorMessageWithoutConfirmPass.Text);
        }
        public static void AssertExistUserErrorMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageExistUser.Displayed);
            StringAssert.Contains(text, page.ErrorMessageExistUser.Text);
        }
        public static void AssertShortPassErrorMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageShortPassword.Displayed);
            StringAssert.Contains(text, page.ErrorMessageShortPassword.Text);
        }
        public static void AssertPassDoesnNotMatchMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagePasswordDoesNotMatch.Displayed);
            StringAssert.Contains(text, page.ErrorMessagePasswordDoesNotMatch.Text);
        }
        public static void AssertWrongPhoneMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageWrongPhone.Displayed);
            StringAssert.Contains(text, page.ErrorMessageWrongPhone.Text);
        }
        public static void AssertWithInvalidPicture(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageWitIncorectPicture.Displayed);
            StringAssert.Contains(text, page.ErrorMessageWitIncorectPicture.Text);
        }
          
    }
}
