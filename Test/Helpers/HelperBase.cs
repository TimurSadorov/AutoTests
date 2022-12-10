using OpenQA.Selenium;

namespace Test.Helpers;

public abstract class HelperBase
{
    protected readonly IWebDriver Driver;

    protected HelperBase(IWebDriver driver)
    {
        Driver = driver;
    }
}