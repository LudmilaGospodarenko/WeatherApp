using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using OpenQA.Selenium.Interactions;
using System.Drawing;

namespace WeatherApp.Pages
{
    class StartPage
    {
        private IWebDriver driver;
        const string url = "https://vk.com/im";

        [FindsBy(How = How.Id, Using = "im_dialogs_search")]
        private IWebElement search;

        [FindsBy(How = How.XPath, Using = "//*[@class='ui_scroll_content clear_fix']/li[2]")]
        private IWebElement foundPerson;

        [FindsBy(How = How.XPath, Using = "//*[@id='im_editable0']")]
        private IWebElement messageField;


        public StartPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void GoToUrl()
        {
            driver.Navigate().GoToUrl(url);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2000));
            IWebElement title = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("top_home_logo")));
        }

        public void OpenChat( string user)
        {
            search.SendKeys(user);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2000));
            IWebElement title = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class='ui_scroll_content clear_fix']/li[1]")));
            foundPerson.Click();
        }

        public void SendMesage(string message)
        {
            messageField.SendKeys(message + Keys.Enter);
        }
    }
}