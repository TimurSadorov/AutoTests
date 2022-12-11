using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

[TestFixture]
public class Tests
{
    private IWebDriver _driver;

    [SetUp]
    public void SetUp()
    {
        _driver = new ChromeDriver();
    }

    [TearDown]
    protected void TearDown()
    {
        _driver.Quit();
    }

    [Test]
    public void AuthTest()
    {
        _driver.Navigate().GoToUrl("https://ticktick.com/");
        _driver.FindElement(By.LinkText("Войти")).Click();
        _driver.FindElement(By.Id("emailOrPhone")).SendKeys("sadorov2001@mail.ru");
        _driver.FindElement(By.Id("password")).Click();
        _driver.FindElement(By.Id("password")).SendKeys("hk21002001");
        _driver.FindElement(By.CssSelector(".button__3eXSs")).Click();
    }
}