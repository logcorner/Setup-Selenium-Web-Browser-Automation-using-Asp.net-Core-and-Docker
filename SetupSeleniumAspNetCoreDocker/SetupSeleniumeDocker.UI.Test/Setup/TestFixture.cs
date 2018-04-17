using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SetupSeleniumeDocker.UI.Test.Setup
{
    public class TestFixture : IDisposable
    {
        public readonly IWebDriver WebDriver;

        public TestFixture()
        {
            //TODO : move to folder whereis  docker-compose file
            //TODO run command docker-compose build
            //TODO run command docker-compose up

            WebDriver = new ChromeDriver(@"C:\Selenium\drivers");
            WebDriver.Navigate().GoToUrl("http://localhost:8080/");
        }

        public void Dispose()
        {
            WebDriver.Dispose();
            //TODO run command docker-compose down
        }
    }
}