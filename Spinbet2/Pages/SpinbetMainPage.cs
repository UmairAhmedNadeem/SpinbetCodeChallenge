using SpinbetCore;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;


namespace Spinbet2.Pages
{
    
    public class SpinbetMainPage : Core
    {
        string Signinbutton = "sign-in-btn";

        public void Signupbtn()
        {
           var sign = driver.FindElement(By.LinkText("Sign in"));
       //     driver.FindElement(By.link(Signinbutton)).Click();
            Thread.Sleep(1000);
            sign.Click();
        }
    }
}
