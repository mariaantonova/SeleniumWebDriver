using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Threading;

class EntryPoint
{
    static void Main()
    {
        string url = "https://mariaantonova.000webhostapp.com/";
        string cssPath = "#slideshow > div > div > div > div > div > h";
        string xPath = "//*[@id=\"slideshow\"]/div/div/div/div/div/h2";

        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl(url);

        IWebElement cssPathElement;
        IWebElement xPathElement = driver.FindElement(By.XPath(xPath));

        try
        {
            cssPathElement = driver.FindElement(By.CssSelector(cssPath));

            if (cssPathElement.Displayed)
            {
                GreenMessage("I can see css Path element");
            }
        }
        catch (NoSuchElementException)
        {
            RedMessage("I can't see the css Path element");
        }

        try
        {
            if (xPathElement.Displayed)
            {
                GreenMessage("I can see xPath element");
            }
        }
        catch (NoSuchElementException)
        {
            RedMessage("I can't see xPath element");
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
