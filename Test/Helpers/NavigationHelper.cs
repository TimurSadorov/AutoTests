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
    
    public void OpenList(string nameList)
    {
        var lists = Driver.FindElement(By.Id("project-ul"));
        var deletableList = lists.FindElements(By.ClassName("project"))
            .FirstOrDefault(element => element.Text?.IndexOf(nameList) >= 0);
        if (deletableList is not null)
        {
            deletableList.Click();
            Thread.Sleep(1000);
        }
    }
    
    public void OpenHomePage()
    {
        Driver.Navigate().GoToUrl(_baseUrl);
        Thread.Sleep(1000);
    }
}