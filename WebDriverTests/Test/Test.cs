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
using WebDriverTests.Driver;

namespace WebDriverTests
{
    public class Tests
    {
        private IWebDriver driver;
        private string _searchText = "Кепка";
        private string _shirtsText = "РУБАШКИ";
        private string _cartText = "Корзина";
        private string _collectionText = "Коллекция";
        private string _logoText = "Интернет-магазин";
        private string _discountText = "Скидки";
        private string _contactsText = "Контакты";

        [SetUp]
        public void Setup()
        {
            driver = DriverSingelton.GetDriver();
            driver.Navigate().GoToUrl("http://lee-cooper.by/");
        }

        [Test]
        public void FindJacketTest()
        {
            MainPage mainPage = new MainPage(driver);
            Assert.True(mainPage.Search(SearchCreate.CreateSearchWithCredentialsString()).Contains(_searchText));
        }

        [Test]
        public void FindShirtsTest()
        {
            MainPage mainPage = new MainPage(driver);
            Assert.True(mainPage.FindShirts().Contains(_shirtsText));
        }

        [Test]
        public void CartButtonTest()
        {
            MainPage mainPage = new MainPage(driver);
            Assert.True(mainPage.ClickCartButton().Contains(_cartText));
        }

        [Test]
        public void CartCounterTest()
        {
            MainPage mainPage = new MainPage(driver);
            ProductPage productPage = new ProductPage(driver);
            mainPage.Search(SearchCreate.CreateSearchWithCredentialsString());
            mainPage.ClickProductButton();
            Assert.True(productPage.CheckCartCounter().Equals((1).ToString()));
        }

        [Test]
        public void CollectionButtonTest()
        {
            MainPage mainPage = new MainPage(driver);
            Assert.True(mainPage.ClickCollectionButton().Contains(_collectionText));
        }

        [Test]
        public void LogoButtonTest()
        {
            MainPage mainPage = new MainPage(driver);
            Assert.True(mainPage.ClickLogoButton().Contains(_logoText));
        }

        [Test]
        public void DiscountButtonTest()
        {
            MainPage mainPage = new MainPage(driver);
            Assert.True(mainPage.ClickDiscountsButton().Contains(_discountText));
        }

        [Test]
        public void ContactsButtonTest()
        {
            MainPage mainPage = new MainPage(driver);
            Assert.True(mainPage.ClickContactsButton().Contains(_contactsText));
        }

        [TearDown]
        public void CloseBrowser()
        {
            Thread.Sleep(5000);
            driver.Close();
        }
    }
}
