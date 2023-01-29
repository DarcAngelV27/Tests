using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace SeleniumTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //create the reference for the browser  
            IWebDriver driver = new ChromeDriver();

            // navigate to URL  
            driver.Navigate().GoToUrl("https://en.wikipedia.org/wiki/Main_Page");
            Thread.Sleep(2000);

            //Maximize the browser window  
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            // identify the search text box  
            IWebElement ele = driver.FindElement(By.Name("search"));

            //enter the value in the search text box  
            ele.SendKeys("Automation testing");
            Thread.Sleep(2000);

            //identify the search button  
            IWebElement ele1 = driver.FindElement(By.ClassName("cdx-button"));

            // click on the search button  
            ele1.Click();
            Thread.Sleep(3000);

            //Verify search results
            driver.FindElement(By.XPath("//*[contains(., 'Test automation can automate some repetitive but necessary tasks in a formalized testing process')]"));
            Console.WriteLine("Text found!");

            //close the browser  
            driver.Close();
            Console.WriteLine("Test complete");
        }
    }
}