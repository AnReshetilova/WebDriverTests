using System;
using OpenQA.Selenium;
using WebDriverTests.Model;

namespace WebDriverTests.Page
{
    public class MainPage
    {
        private IWebDriver driver;
        private readonly By SearchButton = By.XPath("/html/body/header/section/div/div/div[1]/form/div/div");
        private readonly By SearchInput = By.XPath("/html/body/header/section/div/div/div[1]/form/div/input");
        private readonly By SearchResult = By.XPath("/html/body/div[2]/div/div[2]/div[2]/div[1]/figure/figcaption/a");
        private readonly By logoButton = By.XPath("//img[@class='header-logo-image logo']");
        private readonly By logoText = By.XPath("/html/body/section[1]/div/div/div/h1");
        private readonly By DropdownCatalogButton = By.XPath("//button[@class='btn btn-primary dropdown-toggle']");
        private readonly By ShirtsCatalogButton = By.XPath("//a[text()='РУБАШКИ']");
        private readonly By ShirtsHeader = By.XPath("/html/body/div[2]/div/div[2]/div[2]/div[1]");
        private readonly By CartButton = By.XPath("/html/body/header/section/div/div/div[2]/div[2]/a[2]");
        private readonly By CartText = By.XPath("/html/body/div[1]/nav/ol/li[2]");
        private readonly By productButton = By.XPath("/html/body/div[2]/div/div[2]/div[2]/div[1]");
        private readonly By collectionButton = By.XPath("/html/body/section[2]/div/div/div[1]/header/a");
        private readonly By collectionText= By.XPath("/html/body/div[2]/div/div[2]/div[1]/div/p");
        private readonly By discountsButton = By.XPath("/html/body/header/nav/div/div/ul/li[3]/a");
        private readonly By discountsText = By.XPath("/html/body/div[1]/nav/ol/li[2]/span");
        private readonly By contactsButton = By.XPath("/html/body/header/nav/div/div/ul/li[5]/a");
        private readonly By contactsText = By.XPath("/html/body/div[1]/nav/ol/li[2]/span");


        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickProductButton()
        {
            driver.FindElement(productButton).Click();
        }

        public string FindShirts()
        {
            driver.FindElement(DropdownCatalogButton).Click();
            driver.FindElement(ShirtsCatalogButton).Click();
            return driver.FindElement(ShirtsHeader).Text;
        }

        public string Search(Search search)
        {
            driver.FindElement(SearchInput).SendKeys(search.SearchString);
            driver.FindElement(SearchButton).Click();
            return driver.FindElement(SearchResult).Text;
        }

        public string ClickCartButton()
        {
            driver.FindElement(CartButton).Click();
            return driver.FindElement(CartText).Text;
        }

        public string ClickCollectionButton()
        {
            driver.FindElement(collectionButton).Click();
            return driver.FindElement(collectionText).Text;
        }

        public string ClickLogoButton()
        {
            driver.FindElement(logoButton).Click();
            return driver.FindElement(logoText).Text;
        }
        public string ClickDiscountsButton()
        {
            driver.FindElement(discountsButton).Click();
            return driver.FindElement(discountsText).Text;
        }

        public string ClickContactsButton()
        {
            driver.FindElement(contactsButton).Click();
            return driver.FindElement(contactsText).Text;
        }
    }
}
