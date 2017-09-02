using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
class EntryPoint
{
    static void Main()
    {
        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl("https://mariaantonova.000webhostapp.com/2017/08/17/today-i-receive-a-badge-of-certified-ui-tester/");

        IWebElement element = driver.FindElement(By.Name("comment"));

        if (element.Displayed) 
        {
            GreenMessage("Yes. I can see the element!");
        } 
        else 
        { 
            RedMessage("Well, something went wrong, I couldn't see the element!"); 
        }

        Thread.Sleep(5000);

        driver.Quit();
    }
    private static void RedMessage(string message) 
    { 
        Console.ForegroundColor = ConsoleColor.Red; 
        Console.WriteLine(message); 
        Console.ForegroundColor = ConsoleColor.White; }
    private static void GreenMessage(string message)
    { 
        Console.ForegroundColor = ConsoleColor.Green; 
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White; 
    }
}