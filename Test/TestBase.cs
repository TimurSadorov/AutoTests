using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Test;

public class TestBase
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
    
    public void CreateList(ListData listData)
    {
        _driver.FindElement(By.Id("edit-project-name")).Click();
        _driver.FindElement(By.Id("edit-project-name")).SendKeys(listData.Name);
        _driver.FindElement(By.CssSelector(".ap-button-primary")).Click();
        Thread.Sleep(2000);
    }

    public void OpenCreateListForm()
    {
        _driver.FindElement(By.CssSelector(".hoverSection:nth-child(1) .add-icon use")).Click();
    }

    public void Login(AccountData account)
    {
        _driver.FindElement(By.LinkText("Войти")).Click();
        _driver.FindElement(By.Id("emailOrPhone")).SendKeys(account.Email);
        _driver.FindElement(By.Id("password")).Click();
        _driver.FindElement(By.Id("password")).SendKeys(account.Password);
        _driver.FindElement(By.CssSelector(".button__3eXSs")).Click();
        Thread.Sleep(7000);
    }

    public void OpenHomePage()
    {
        _driver.Navigate().GoToUrl("https://ticktick.com/");
    }
}