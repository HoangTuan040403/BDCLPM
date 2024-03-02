using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Project
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver;
        [TestInitialize]
        public void Test1OpenWeb()
        {
           
            driver = new ChromeDriver();
            driver.Url = "http://localhost:8080/#/";
            driver.Navigate();
            Thread.Sleep(2000);

        }
        [TestMethod]
        public void Test2OpenFlghtWeb()
        {
            //driver.SwitchTo().NewWindow(WindowType.Tab);
            //driver.Navigate().GoToUrl("http://localhost:8080/#/");
            //Thread.Sleep(2000);

            IWebElement loginButton = driver.FindElement(By.ClassName("acount_link"));
            loginButton.Click();

            //nhập thông tin đăng nhập
            IWebElement emailField = driver.FindElement(By.CssSelector("input[placeholder='Enter email']"));
            emailField.SendKeys("hoangtuan040403@gmail.com");
            Thread.Sleep(2000);

            IWebElement pass = driver.FindElement(By.Id("password"));
            pass.SendKeys("Tt123456");
            Thread.Sleep(2000);

            //đăng nhập
            emailField.SendKeys(Keys.Enter);

            //IWebElement divLocation = driver.FindElement(By.CssSelector("div.location"));
            //divLocation.Click();

            //IWebElement divLocation = driver.FindElement(By.ClassName("location"));
            //divLocation.Click();

            Thread.Sleep(2000);
            IWebElement locationElement = driver.FindElement(By.CssSelector("div.location"));
            locationElement.Click();
            Thread.Sleep(2000);

            driver.FindElement(By.CssSelector(".name input")).Click();
            driver.FindElement(By.CssSelector(".name input")).SendKeys("TPHCM");

            driver.FindElement(By.CssSelector(".contry input")).Click();
            driver.FindElement(By.CssSelector(".contry input")).SendKeys("Việt Nam");
            driver.FindElement(By.Id("file")).Click();
            driver.FindElement(By.Id("file")).SendKeys("C:\\Pictures\\265&3&danang.jpg");
            driver.FindElement(By.CssSelector(".ADD")).Click();
        }


        //[TestMethod]
        //public void Testadd()
        //{
        //    var add = driver.FindElements(By.XPath("/html/body/div/div[2]/div/div[2]/div/form/div[1]/div[1]/select"));
        //    if (add.Count> 0)
        //    {
        //        add[0].Click();
        //        add[0].SendKeys(Keys.Enter);
        //    }

        //}


    }
}
