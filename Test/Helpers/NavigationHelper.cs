using OpenQA.Selenium;

namespace Test.Helpers;

public class NavigationHelper: HelperBase
{
    private readonly string _baseUrl;
    
    public NavigationHelper(IWebDriver driver, string baseUrl) : base(driver)
    {
        _baseUrl = baseUrl;
    }

    public void OpenCreateListForm()
    {
        Driver.FindElement(By.CssSelector(".hoverSection:nth-child(1) .add-icon use")).Click();
    }
    
    public void OpenHomePage()
    {
        Driver.Navigate().GoToUrl(_baseUrl);
    }
}