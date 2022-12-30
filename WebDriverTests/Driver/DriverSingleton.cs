using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace WebDriverTests.Driver
{
    public class DriverSingelton
    {
        private static IWebDriver driver;

        private DriverSingelton()
        {
        }

        public static IWebDriver GetDriver()
        {

            new DriverManager().SetUpDriver(new ChromeConfig());
            if (driver == null)
            {
                driver = new ChromeDriver();
            }

            return driver;
        }

        public static void CloseDriver()
        {
            driver.Quit();
            driver = null;
        }
    }
}
