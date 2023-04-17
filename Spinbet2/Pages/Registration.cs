using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using SpinbetCore;
using OpenQA.Selenium.Internal;

public class RegistrationForm : Core
{
   
    string RegisterTab = "Register";
    string username = "reg-username";
    string emailId = "reg-email";
    string password = "reg-password";
    string CurrenyDropDown = ".fm-cr-sel";
    string datemonth = "dt-mm";
    string dateday = "dt-day";
    string dateyear = "dt-yy";
    string promotioncode = "reg-code";
    string termscheckbox = "reg-terms";
    string registersubmitbtn= "reg-btn";

    
    public void Registertab()
    {
        Thread.Sleep(500);

        driver.FindElement(By.LinkText(RegisterTab)).Click();
        Thread.Sleep(500);
    }
    public void Title()
    {
        string title = driver.Title; 
    }
    public void UsernameTextbox(string Enterusername)
    {

        driver.FindElement(By.Id(username)).SendKeys(Enterusername);
        Thread.Sleep(500);
    }
    
    public void PasswordTextbox(string EnterPassword)
    {
        driver.FindElement(By.Id(password)).SendKeys(EnterPassword);
        Thread.Sleep(500);

     }
    public void EmailIdTextbox(string EnterEmailID)
    {
        driver.FindElement(By.Name(emailId)).SendKeys(EnterEmailID);
        Thread.Sleep(500);

    }
    public void CurrencyDropDownSelection(string CurrencyCode)
    {
        driver.FindElement(By.CssSelector(".fm-cr-sel")).Click();
        Thread.Sleep(1000);
        var currencyDropdown = driver.FindElement(By.ClassName("fm-cr-dp-list"));
        var currencyOptions = currencyDropdown.FindElements(By.TagName("a"));
                
        foreach (var option in currencyOptions)
        {
            if (option.GetAttribute("data-cur") == CurrencyCode)
            {
                option.Click();
            }
        }
    }
    public void DateMonth(string EnterMonth)
    {
        driver.FindElement(By.Id(datemonth)).SendKeys(EnterMonth);
        Thread.Sleep(1000);

    }
    public void DateDate(string EnterDate)
    {
        driver.FindElement(By.Id(dateday)).SendKeys(EnterDate);
        Thread.Sleep(1000);
    }

    public void DateYear(string EnterYear)
    {
        driver.FindElement(By.Id(dateyear)).SendKeys(EnterYear);
        Thread.Sleep(1000);
    }

    public void PromotionCode(string EnterPromotionCode)
    {
        driver.FindElement(By.Id(promotioncode)).SendKeys(EnterPromotionCode);
    }

    public void TermsCheckboxSelect()
    {
        var termscheckboxElement = driver.FindElement(By.Id(termscheckbox));
        bool isChecked = termscheckboxElement.Selected;
        Thread.Sleep(100);
        if (!isChecked)
        {
            termscheckboxElement.Click();
        }
      
      
    }

    public void Recaptcha()
    {

        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        wait.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt(By.CssSelector("iframe[src*='recaptcha']")));
        // Wait until the reCAPTCHA checkbox is available and click it
        IWebElement recaptchaCheckbox = wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("div.recaptcha-checkbox-checkmark")));
        recaptchaCheckbox.Click();

        // Switch back to the main content of the webpage
        driver.SwitchTo().DefaultContent();

        // IWebElement SecondResult = wait.Until(e => e.FindElement(By.XPath("//div[@class='recaptcha-checkbox-border']"))).Click();
    }

    public void RegisterSubmit()
    {
        var formgroupbtn = driver.FindElement(By.ClassName("form-group-btn"));
        var regbtn = driver.FindElement(By.ClassName(registersubmitbtn));
        Thread.Sleep(200);
            regbtn.Click();
            regbtn.Click();
    }

   
}
