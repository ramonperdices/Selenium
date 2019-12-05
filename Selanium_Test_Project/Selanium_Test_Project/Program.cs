using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selanium_Test_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            string search_this_string;
            Console.WriteLine("What would you like to search in google?");
            search_this_string = Console.ReadLine();
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Maximize();
            IWebElement element = driver.FindElement(By.Name("q"));
            element.SendKeys(search_this_string);
            element.Submit();
            //driver.Close();
            //driver.Quit();
        }
    }
}