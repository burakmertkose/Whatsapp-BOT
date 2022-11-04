using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WhatsappBot.Utilities;

namespace WhatsappBot.PageObjectModel
{
    class Whatsapp
    {

        WebDriver webDriver;
        static WebDriverWait webDriverWait;
        public static List<string> contactUser;

        public Whatsapp()
        {
            webDriver = Driver.getWebDriver();
            if (webDriverWait == null)
            {
                webDriverWait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            }

        }

        public string getMyNumber()
        {
            string myNumber = "";
            try
            {
                webDriverWait = new WebDriverWait(webDriver,TimeSpan.FromSeconds(10));
                // Click Profile span
                webDriverWait.Until(webDriver => webDriver.FindElement(By.XPath("//span[@data-testid='default-user']")));
                Driver.ClickElement(webDriver.FindElement(By.XPath("//span[@data-testid='default-user']")));
                Thread.Sleep(500);
                // Get text
                webDriverWait.Until(webDriver => webDriver.FindElement(By.XPath("//div[contains(@class,'erpdyial')]")));
                myNumber = webDriver.FindElement(By.XPath("//div[contains(@class,'erpdyial')]")).Text;
                
                backButton();

                return myNumber;
            }
            catch (Exception)
            {
                webDriver.Navigate().Refresh();
                return myNumber;
            }

        }

        private void backButton()
        {
            try
            {
                Thread.Sleep(500);
                webDriverWait.Until(webDriver => webDriver.FindElement(By.XPath("//div[@data-testid='btn-closer-drawer']")));
                Driver.ClickElement(webDriver.FindElement(By.XPath("//div[@data-testid='btn-closer-drawer']")));
            }
            catch (Exception)
            {

                webDriver.Navigate().Refresh();
            }
            // Return Main Page

        }

        public void getContactList()
        {
            webDriverWait = new WebDriverWait(webDriver,TimeSpan.FromSeconds(15));
            List<string> contacts = new List<string>();
            webDriver.Navigate().Refresh();
            webDriverWait.Until(webDriver => webDriver.FindElement(By.XPath("//span[@data-testid='chat']")));
            try
            {

                //Click New Chat
                chatClick();


                int breakTry = 0;
                while (true)
                {
                    webDriverWait.Until(webDriver => webDriver.FindElement(By.XPath("(//div[@role='gridcell']//span[@dir='auto'])[1]")));
                    IReadOnlyCollection<IWebElement> webElements = webDriver.FindElements(By.XPath("//div[@role='gridcell']//span[@dir='auto']"));

                    foreach (var element in webElements)
                    {
                        if (!contacts.Contains(element.Text))
                        {
                            contacts.Add(element.Text);
                            breakTry = 0;
                        }
                    }
                    webDriverWait.Until(webDriver => webDriver.FindElement(By.XPath("//div[@data-testid='new-chat-drawer']/div[contains(@class,' ')]")));
                    IWebElement element1 = webDriver.FindElement(By.XPath("//div[@data-testid='new-chat-drawer']/div[contains(@class,' ')]"));
                    IJavaScriptExecutor js = (IJavaScriptExecutor)webDriver;
                    js.ExecuteScript("arguments[0].scrollBy(0,400)", element1);
                    Thread.Sleep(25);
                    if (breakTry > 5)
                        break;
                    breakTry++;
                }

                backButton();

                contactUser = contacts;

            }
            catch (Exception)
            {
                contactUser = contacts;
            }
        }

        private void chatClick()
        {
            try
            {
                webDriverWait.Until(webDriver => webDriver.FindElement(By.XPath("//span[@data-testid='chat']")));
                Driver.ClickElement(webDriver.FindElement(By.XPath("//span[@data-testid='chat']")));
            }
            catch (Exception)
            {
            }

        }

        public void quitWhatsapp()
        {
            webDriverWait = new WebDriverWait(webDriver,TimeSpan.FromSeconds(15));
            try
            {
               
                // Click Bar Menu
                webDriverWait.Until(webDriver => webDriver.FindElement(By.XPath("//div[@data-testid='menu-bar-menu']")));
                webDriver.FindElement(By.XPath("//div[@data-testid='menu-bar-menu']")).Click();
                Thread.Sleep(2000);
                // Click Logout Button
                webDriverWait.Until(webDriver => webDriver.FindElement(By.XPath("//li[contains(@data-testid,'logout')]")));
                webDriver.FindElement(By.XPath("//li[contains(@data-testid,'logout')]")).Click();
                Thread.Sleep(500); 
                
                webDriverWait.Until(webDriver => webDriver.FindElement(By.XPath("//div[contains(@data-testid,'ok')]")));
                webDriver.FindElement(By.XPath("//div[contains(@data-testid,'ok')]")).Click();
                Thread.Sleep(500);

            }
            catch (Exception)
            {
                throw;
            }

        }

        public void sendMessage(string contactUser, string message, int count, int delay)
        {
            chatClick();
            try
            {
                webDriverWait.Until(webDriver => webDriver.FindElement(By.XPath("(//div[@data-testid='chat-list-search'])[1]")));
                webDriver.FindElement(By.XPath("(//div[@data-testid='chat-list-search'])[1]")).Click();
                webDriver.FindElement(By.XPath("(//div[@data-testid='chat-list-search'])[1]")).SendKeys(contactUser);
                Thread.Sleep(300);

                webDriverWait.Until(webDriver => webDriver.FindElement(By.XPath("(//div[@data-testid='cell-frame-container'])[1]")));
                webDriver.FindElement(By.XPath("(//div[@data-testid='cell-frame-container'])[1]")).Click();
                Thread.Sleep(150);

            }
            catch (Exception)
            {
            }
        

            for (int i = 0; i < count; i++)
            {
                try
                {
                   
                    webDriverWait.Until(webDriver => webDriver.FindElement(By.XPath("//div[contains(@data-testid,'box-input')]")));
                    webDriver.FindElement(By.XPath("//div[contains(@data-testid,'box-input')]")).SendKeys(message);
                    Thread.Sleep(100);
                    webDriver.FindElement(By.XPath("//div[contains(@data-testid,'box-input')]")).SendKeys(Keys.Enter);

                    Thread.Sleep(delay*1000);
                }
                catch (Exception)
                {
                }


            }
        }
    }
}
