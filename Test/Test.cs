using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

[TestFixture]
public class Test
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

    [Test]
    public void test1()
    {
        OpenHomePage();
        driver.FindElement(By.LinkText("Войти")).Click();
        driver.FindElement(By.Id("emailOrPhone")).SendKeys("sadorov2001@mail.ru");
        driver.FindElement(By.Id("password")).Click();
        driver.FindElement(By.Id("password")).SendKeys("hk21002001");
        driver.FindElement(By.CssSelector(".button__3eXSs")).Click();
    }

    private void OpenHomePage()
    {
        driver.Navigate().GoToUrl("https://ticktick.com/");
    }
}