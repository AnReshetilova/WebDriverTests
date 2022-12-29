using System;
using OpenQA.Selenium;
using WebDriverTests.Model;

namespace WebDriverTests.Page
{
    public class MainPage
    {
        private IWebDriver driver;
        private readonly By CatalogButton = By.XPath("/html/body/header/section/div/div/div[1]/div/button");
        private readonly By BackToMainPageButton = By.XPath("/html/body/header/nav/div/a/img");
        private readonly By ContactsButton = By.XPath("/html/body/header/section/div/div/div[2]/div[2]/a[1]/div");
       // private readonly By FAQButton = By.XPath("//a[text()='FAQ']");
        //private readonly By OPtButton = By.XPath("//a[text()='Опт']");
        private readonly By dostavkaButton = By.XPath("//a[text()='Доставка']");
        private readonly By SearchButton = By.XPath("/html/body/header/section/div/div/div[1]/form/div/div");
        private readonly By SearchInput = By.XPath("/html/body/header/section/div/div/div[1]/form/div/input");
        private readonly By SearchResult = By.XPath("/html/body/div[2]/div/div[2]/div[2]/div[1]/figure/figcaption/a");
        private readonly By MenuResult = By.XPath("//div[text()='Рюкзак:']");
        private readonly By logoButton = By.XPath("//img[@class='header-logo-image logo']");
        private readonly By dropdownCatalogButton = By.XPath("//button[@class='btn btn-primary dropdown-toggle']");
        private readonly By shirtsCatalogButton = By.XPath("//a[text()='РУБАШКИ']");
        private readonly By shirtsComfortCatalogButton = By.XPath("/html/body/div[2]/div/div[1]/ul/li[3]/a");
        private readonly By accessoriesCatalogButton = By.XPath("//a[text()='АКСЕССУАРЫ']");
        private readonly By hatsAccessoriesCatalogButton = By.XPath("/html/body/div[2]/div/div[1]/ul/li[2]/a");


        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public String ClickCatalogButton()
        {
            driver.FindElement(CatalogButton).Click();
            return driver.FindElement(MenuResult).Text;

        }
        //public void ClickKonstructorButton()
        //{
        //    driver.FindElement(KonstructorButton).Click();
        //}
        //public void ClickAboutBrandButton()
        //{
        //    driver.FindElement(AboutBrandButton).Click();
        //}
        //public void ClickContactsButton()
        //{
        //    driver.FindElement(ContactsButton).Click();
        //}
        //public void ClickSkidkiButton()
        //{
        //    driver.FindElement(SkidkiButton).Click();
        //}
        //public void ClickFAQButton()
        //{
        //    driver.FindElement(FAQButton).Click();
        //}
        //public void ClickOPtButton()
        //{
        //    driver.FindElement(OPtButton).Click();
        //}
        public void ClickdostavkaButton()
        {
            driver.FindElement(dostavkaButton).Click();
        }
        //public void ClickAllButtons()
        //{
        //    ClickCatalogButton();
        //    ClickKonstructorButton();
        //    ClickAboutBrandButton();
        //    ClickContactsButton();
        //    ClickSkidkiButton();
        //    ClickFAQButton();
        //    ClickOPtButton();
        //    ClickdostavkaButton();
        //}

        public string Search(Search search)
        {
            driver.FindElement(SearchInput).SendKeys(search.SearchString);
            driver.FindElement(SearchButton).Click();
            return driver.FindElement(SearchResult).Text;
        }
    }
}
