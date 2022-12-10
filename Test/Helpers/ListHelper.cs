using OpenQA.Selenium;
using Test.Model;

namespace Test.Helpers;

public class ListHelper: HelperBase
{
    public ListHelper(IWebDriver driver) : base(driver)
    {
    }
    
    public void CreateList(ListData listData)
    {
        Driver.FindElement(By.Id("edit-project-name")).Click();
        Driver.FindElement(By.Id("edit-project-name")).SendKeys(listData.Name);
        Driver.FindElement(By.CssSelector(".ap-button-primary")).Click();
        Thread.Sleep(2000);
    }
}