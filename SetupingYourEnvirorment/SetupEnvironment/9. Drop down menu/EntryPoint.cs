using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading.Tasks;
using System.Threading;


class EntryPoint
{
    static IWebDriver driver = new ChromeDriver();
    static IWebElement dropDownMenu;
    static IWebElement elementFromDropDownMenu;

    static void Main()
    {
        string url = "https://mariaantonova.000webhostapp.com/2017/08/21/drop-down-menu-for-testing/";
        string dropDownMenuElements = "#post-106 > div > p > select > option:nth-child(1)";

        driver.Navigate().GoToUrl(url);

        dropDownMenu = driver.FindElement(By.Name("DropDownTest"));

        elementFromDropDownMenu = driver.FindElement(By.CssSelector(dropDownMenuElements));

        Console.WriteLine("The first element is: " + elementFromDropDownMenu.GetAttribute("value"));

        Console.WriteLine("Selected value is: " + dropDownMenu.GetAttribute("value"));
       
        Thread.Sleep(5000);

        driver.Quit();
    }
}

