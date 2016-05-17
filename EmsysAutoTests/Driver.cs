using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace EmsysAutoTests
{
    public class Driver
    {
        public static IWebDriver Instance { get; set;  }
        public static void Initialize() {
            Instance = new ChromeDriver();
            Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(60));
        }

        public static void Close() {
            Instance.Close();
        }
    }
}