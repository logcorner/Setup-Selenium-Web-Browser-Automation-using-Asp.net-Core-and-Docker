using OpenQA.Selenium;
using SetupSeleniumeDocker.UI.Test.Setup;
using Xunit;

namespace SetupSeleniumeDocker.UI.Test
{
    public class HomePageTest : IClassFixture<TestFixture>
    {
        private IWebDriver WebDriver { get; }

        public HomePageTest(TestFixture fixture)
        {
            WebDriver = fixture.WebDriver;
        }

        [Fact(DisplayName = "Application loaded successfully")]
        public void WhenNavigatingOnTheHomeUrlThenTheHomePageIsDisplayedCorrectly()
        {
            var title = WebDriver.FindElement(By.ClassName("navbar-brand"));

            Assert.Equal("SetupSeleniumeDocker.UI", title.Text);
        }
    }
}