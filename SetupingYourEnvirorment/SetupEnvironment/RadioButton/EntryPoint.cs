using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading.Tasks;
using System.Threading;

class EntryPoint
{
    static IWebDriver driver = new ChromeDriver();

    static IWebElement radioButton;
    static void Main()
    {
        string url = "https://mariaantonova.000webhostapp.com/2017/08/21/radiobuttons-for-testing-purposes/";
        string[] option = {"2", "4", "6", "8"};

        driver.Navigate().GoToUrl(url);
        

        for (int i = 0; i < option.Length; i++)
        {
            radioButton = driver.FindElement(By.CssSelector("#post-96 > div > p > input[type=\"radio\"]:nth-child(" + option[i] + ")"));

            if (radioButton.GetAttribute("checked") == "true")
            {
                Console.WriteLine("The " + "radio button " + (i +  1)  + " is checked!");
            }

            else
            {
                Console.WriteLine("Radio button is not checked!");
            }
            }
        Thread.Sleep(5000);
        driver.Quit();
    }
}
