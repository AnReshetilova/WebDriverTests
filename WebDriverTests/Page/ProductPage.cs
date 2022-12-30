using System;
using OpenQA.Selenium;
using WebDriverTests.Model;


namespace WebDriverTests.Page
{
    class ProductPage
    {
        private IWebDriver driver;
        private readonly By AddToCartButton = By.XPath("/html/body/div[2]/div/div[1]/div[1]/div[2]/form/div[4]/div");
        private readonly By ProductInCart = By.XPath("/html/body/header/section/div/div/div[2]/div[2]/a[2]/div/div[1]/small");
        private readonly By sizeButton = By.XPath("/html/body/div[2]/div/div[1]/div[1]/div[2]/form/div[5]/label[1]");
        private readonly By colorButton = By.XPath("/html/body/div[2]/div/div[1]/div[1]/div[2]/form/div[7]/label[1]");

        public ProductPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string CheckCartCounter()
        {
            driver.FindElement(AddToCartButton).Click();
            return driver.FindElement(ProductInCart).Text;
        }
    }
}
