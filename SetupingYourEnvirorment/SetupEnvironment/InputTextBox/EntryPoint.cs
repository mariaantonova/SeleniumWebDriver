using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class EntryPoint
{
    static IWebDriver driver = new ChromeDriver();
    static IWebElement textbox;

    static void Main()
    {
        string url = "https://mariaantonova.000webhostapp.com/highlights/";
        driver.Navigate().GoToUrl(url);
        textbox = driver.FindElement(By.Name("s"));
        textbox.SendKeys("Test text");

        Thread.Sleep(5000);

        Console.WriteLine(textbox.GetAttribute("class"));

        Thread.Sleep(5000);

        driver.Quit();
    }
}

