using NUnit.Framework;

namespace Test.Tests;

public class TestBase
{
    protected ApplicationManager App;

    [OneTimeSetUp]
    public void OneTimeSetUpTests()
    {
        App = ApplicationManager.App;
        
        App.NavigationHelper.OpenHomePage();
    }
    
    [SetUp]
    public void SetUpTests()
    {
        App.NavigationHelper.OpenHomePage();
    }
}