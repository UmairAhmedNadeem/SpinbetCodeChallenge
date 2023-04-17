using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using SpinbetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spinbet2.Pages
{
   
    public class SignInpage : Core
    {
        string loginusername = "login-username";
        string loginpassword = "login-password";
        string signinbtn = "btn-main";
        string signinTab = "Sign In";

        public void Title()
        {
            string title = driver.Title;
        }
        public void SignIntab()
        {
            Thread.Sleep(500);

            driver.FindElement(By.LinkText(signinTab)).Click();
            Thread.Sleep(500);
        }
        public void UsernameTextbox(string Enterusername)
        {

            driver.FindElement(By.Id(loginusername)).SendKeys(Enterusername);
            Thread.Sleep(500);
        }

        public void PasswordTextbox(string EnterPassword)
        {
            driver.FindElement(By.Id(loginpassword)).SendKeys(EnterPassword);
            Thread.Sleep(500);

        }

        public void SignInbtn()
        {
            var signbtn = driver.FindElement(By.ClassName("login-btn"));
            Thread.Sleep(500);
            signbtn.Click();

        }

    }
}
