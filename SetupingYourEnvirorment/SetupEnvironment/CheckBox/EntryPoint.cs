using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
class EntryPoint
{
     static IWebDriver driver = new ChromeDriver();
     static IWebElement checkBox;
    static void Main()
    {
        string url = "https://mariaantonova.000webhostapp.com/2017/08/21/radio-buttons-test/"; 
        string option = "4";
        driver.Navigate().GoToUrl(url); 

        checkBox = driver.FindElement(By.CssSelector("#post-83 > div > p > input[type=\"radio\"]:nth-child(" + option + ")"));

        if (checkBox.GetAttribute("checked") == "true")
        {
            Console.WriteLine("The CheckBox is checked!");
        }
        else
        {
            Console.WriteLine("The CheckBox is not checked!");
        }

        Thread.Sleep(5000);

        driver.Quit();
    }
}

