using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhatsappBot.Utilities;

namespace WhatsappBot.PageObjectModel
{
    class LoginWhatsapp
    {
        private WebDriver webDriver = Driver.getWebDriver();

        public void navigateWp()
        {
            webDriver.Navigate().GoToUrl("https://web.whatsapp.com/");
        }

        public void navigateWpRefresh()
        {
            webDriver.Navigate().Refresh();
        }

        public Image getScreenShotQR()
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
                wait.Until(webDriver => webDriver.FindElement(By.XPath("//div[@data-testid='qrcode']")));
                Image image = GetElementScreenShot(webDriver, webDriver.FindElement(By.XPath("//div[@data-testid='qrcode']")));
                return image;
            }
            catch (Exception)
            {
                return null;
            }
        
        }

        public bool loginVerify()
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(7));
                wait.Until(webDriver => webDriver.FindElement(By.XPath("//header[@data-testid='chatlist-header']")));
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public static Bitmap GetElementScreenShot(WebDriver driver, IWebElement element)
        {
            try
            {
                Screenshot sc = ((ITakesScreenshot)driver).GetScreenshot();
                var img = Image.FromStream(new MemoryStream(sc.AsByteArray)) as Bitmap;
                return img.Clone(new Rectangle(element.Location, element.Size), img.PixelFormat);
            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}
