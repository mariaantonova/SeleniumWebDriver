using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
class EntryPoint
{
    static void Main()
    {
        string url = "https://mariaantonova.000webhostapp.com/2017/08/17/today-i-receive-a-badge-of-certified-ui-tester/";
        string className = "posted-on";

        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl(url);
        IWebElement element = driver.FindElement(By.ClassName(className));
        Console.WriteLine(element.Text);

        driver.Quit();
    }
    private static void RedMessage(string message) 
    { 
        Console.ForegroundColor = ConsoleColor.Red; 
        Console.WriteLine(message); 
        Console.ForegroundColor = ConsoleColor.White; 
    }
    private static void GreenMessage(string message) 
    { 
        Console.ForegroundColor = ConsoleColor.Green; 
        Console.WriteLine(message); 
        Console.ForegroundColor = ConsoleColor.White; 
    }
}