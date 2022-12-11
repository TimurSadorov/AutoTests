using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Test.Helpers;

namespace Test;

public class ApplicationManager
{
    private readonly IWebDriver _driver;
    private readonly string _baseUrl;

    private readonly NavigationHelper _navigationHelper;
    private readonly LoginHelper _authHelper;
    private readonly ListHelper _listHelper;
    private readonly TaskHelper _taskHelper;
    
    public static readonly ApplicationManager App = new();

    private ApplicationManager()
    {
        _driver = new ChromeDriver();
        _baseUrl = "https://ticktick.com/";
        
        _navigationHelper = new NavigationHelper(_driver, _baseUrl);
        _authHelper = new LoginHelper(_driver);
        _listHelper = new ListHelper(_driver);
        _taskHelper = new TaskHelper(_driver);
    }

    public NavigationHelper NavigationHelper => _navigationHelper;
    public LoginHelper AuthHelper => _authHelper;
    public ListHelper ListHelper => _listHelper;
    public TaskHelper TaskHelper => _taskHelper;

    public void Stop()
    {
        _driver.Quit();
    }
}