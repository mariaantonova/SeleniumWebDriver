using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
class EntryPoint
{
    static void Main()
    {
        string url = "https://mariaantonova.000webhostapp.com/highlights/";

        string ID = "recent-posts-2";

        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl(url);
        IWebElement element = driver.FindElement(By.Id(ID));

        if (element.Displayed) 
        { 
            GreenMessage("Yes, I can see it!"); 
        } 
        else 
        { 
            RedMessage("It is not there!"); 
        }

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