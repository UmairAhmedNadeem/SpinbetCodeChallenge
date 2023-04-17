using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using SpinbetCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spinbet2.Pages
{
    public class DashboardSearch : Core
    {
        string searchbtn = ".search-btn .search-form-btn";
        string searchbar = ".user-search-col svg";
        string searchid = "search";
        string SearchGameList = ".lb-games-list .game-box";


        public void Title()
        {
            string title = driver.Title;
        }
        public void SearchBtnClick()
        {
            driver.FindElement(By.CssSelector(searchbtn)).Click();

        }
        public void SearchBarClick()
        {
          var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            var Searchbar = wait.Until(ExpectedConditions.ElementExists(By.CssSelector(searchbar)));
            Searchbar.Click();
        }

        public void Search(string EnterSearchTxt)
        {
            driver.FindElement(By.Id(searchid)).SendKeys(EnterSearchTxt);

        }

        public void SearchedGameList()
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            var searchresultlist = wait.Until(ExpectedConditions.ElementExists(By.CssSelector(SearchGameList)));

            ReadOnlyCollection<IWebElement> searchresultlists = driver.FindElements(By.CssSelector(SearchGameList));
            foreach (IWebElement searchresult in searchresultlists)
            {
                IWebElement searchResultLink = searchresult.FindElement(By.TagName("a"));
                string searchResultTitle = searchresult.FindElement(By.TagName("h4")).Text;
                string searchResultProvider = searchresult.FindElement(By.TagName("h5")).Text;
            }
            


        }
    }
}
