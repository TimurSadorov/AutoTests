using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Test;

public class TestBase
{
    private IWebDriver driver;
    public IDictionary<string, object> vars { get; private set; }
    private IJavaScriptExecutor js;

    [SetUp]
    public void SetUp()
    {
        
        driver = new ChromeDriver();
        js = (IJavaScriptExecutor) driver;
        vars = new Dictionary<string, object>();
    }

    [TearDown]
    protected void TearDown()
    {
        driver.Quit();
    }
    
    public void CreateList(ListData listData)
    {
        driver.FindElement(By.CssSelector(".hoverSection:nth-child(1) .add-icon use")).Click();
        driver.FindElement(By.Id("edit-project-name")).Click();
        driver.FindElement(By.Id("edit-project-name")).SendKeys(listData.Name);
        driver.FindElement(By.CssSelector(".ap-button-primary")).Click();
    }

    public void Login(AccountData account)
    {
        driver.FindElement(By.LinkText("Войти")).Click();
        driver.FindElement(By.Id("emailOrPhone")).SendKeys(account.Email);
        driver.FindElement(By.Id("password")).Click();
        driver.FindElement(By.Id("password")).SendKeys(account.Password);
        driver.FindElement(By.CssSelector(".button__3eXSs")).Click();
        Thread.Sleep(7000);
    }

    public void OpenHomePage()
    {
        driver.Navigate().GoToUrl("https://ticktick.com/");
    }
}