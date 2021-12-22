using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System.Threading;

namespace MarsQA_1.Pages
{
    public class SignIn 
    {
        private static IWebElement SignInBtn => Driver.driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div[1]/div/a"));
        private static IWebElement Email => Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
        private static IWebElement Password => Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
        private static IWebElement LoginBtn => Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));

        public static void SigninStep()
        {
            Driver.NavigateUrl();
            SignInBtn.Click();
            Email.SendKeys(ExcelLibHelper.ReadData(2,"username"));
            Password.SendKeys(ExcelLibHelper.ReadData(2, "password"));
            LoginBtn.Click();
        }

        public static void Login()
        {
            Driver.NavigateUrl();
            //Enter Url
            Driver.driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div[1]/div/a")).Click();

            //Enter Username
            Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input")).SendKeys(ExcelLibHelper.ReadData(2, "username"));

            //Enter password
            Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input")).SendKeys(ExcelLibHelper.ReadData(2, "password"));

            //Click on Login Button
            Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button")).Click();

        }  

    }

}