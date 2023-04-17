

using OpenQA.Selenium.Support.UI;

namespace SpinbetCore
{
    public class Core
    {
        public static IWebDriver driver;

        public static void InitializeDriver(string url)
        {
            var options = new ChromeOptions();
           //here we give the path of the chrome browser
              driver = new ChromeDriver("D:\\chromedriver_win32\\chromedriver");
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();

        }

      
        //here we will define the database connection
        public void DatabaseConnect()
        { 
        
        }

        public void AutoScroll()
        {
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            long scrollHeight = (long)jsExecutor.ExecuteScript("return document.body.scrollHeight");
            long windowHeight = (long)jsExecutor.ExecuteScript("return window.innerHeight");
            long scrollStep = 500;

            while (windowHeight < scrollHeight)
            {
                jsExecutor.ExecuteScript($"window.scrollBy(0, {scrollStep})");
                scrollHeight = (long)jsExecutor.ExecuteScript("return document.body.scrollHeight");
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
                wait.Until(driver => (bool)jsExecutor.ExecuteScript($"return (window.innerHeight + window.pageYOffset) >= {scrollHeight}"));
            }
        }
    }
}