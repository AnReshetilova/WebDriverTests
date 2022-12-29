using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using WebDriverTests.Page;
using WebDriverTests.Model;
using WebDriverTests.Service;

namespace WebDriverTests
{
    public class Tests
    {
        private IWebDriver driver;
        private string _searchText = "Куртка";
 
        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("http://lee-cooper.by");
        }

        /*  [Test]
          public void LogoButtonTest()
          {
              var catalog = driver.FindElement(logoButton);
              catalog.Click();
          }

          [Test]
          public void ComfortShirtsButtonTest()
          {
              var catalog = driver.FindElement(dropdownCatalogButton);
              catalog.Click();
              var shirts = driver.FindElement(shirtsCatalogButton);
              shirts.Click();
              var shirtsComfort = driver.FindElement(shirtsComfortCatalogButton);
              shirtsComfort.Click();
          }

          [Test]
          public void HatsButtonTest()
          {
              var catalog = driver.FindElement(dropdownCatalogButton);
              catalog.Click();
              var accessories = driver.FindElement(accessoriesCatalogButton);
              accessories.Click();
              var hats = driver.FindElement(hatsAccessoriesCatalogButton);
              hats.Click();
          }*/

        [Test]
        public void FindJacketTest()
        {
            MainPage mainPage = new MainPage(driver);
            Assert.True(mainPage.Search(SearchCreate.CreateSearchWithCredentialsString()).Contains(_searchText));
        }

        [TearDown]
        public void CloseBrowser()
        {
            Thread.Sleep(5000);
            driver.Close();
        }
    }
}
