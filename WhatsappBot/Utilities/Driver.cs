using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsappBot.Utilities
{
    class Driver
    {

        public static WebDriver webDriver;

        public static WebDriver getWebDriver()
        {
            if (webDriver == null)
            {
                ChromeOptions options = new ChromeOptions();
                options.AddArgument("--headless");
                options.AddArgument("user-agent=User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/98.0.4758.102 Safari/537.36");
                webDriver = new ChromeDriver(options);
                return webDriver;
            }
            return webDriver;
        }

        public static void quitDriver()
        {
            if (webDriver != null)
            {
                webDriver.Quit();
            }
        }

        public static void ClickElement(IWebElement element)
        {
            element.Click();
        }
    }
}
