using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
class EntryPoint
{
    static void Main()
    {
        string url = "https://mariaantonova.000webhostapp.com/highlights/";
        string cssPath = "#search-2 > form > label > input"; 
        string xPath = "//*[@id=\"search-2\"]/form/label/input";

        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl(url);
        IWebElement cssPathElement = driver.FindElement(By.CssSelector(cssPath)); 
        IWebElement xPathElement = driver.FindElement(By.XPath(xPath));

        if (cssPathElement.Displayed) 
        { 
            GreenMessage("I can see the CSS Path Element!"); 
        } 

        else 
        {
            RedMessage("I can't see the CSS Path Element!"); 
        }

        if (xPathElement.Displayed) 
        {
            GreenMessage("I can see the X Path Element!"); 
        } 
        else 
        { 
            RedMessage("I can't see the CSS Path Element!");
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