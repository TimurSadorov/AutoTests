using NUnit.Framework;

namespace Test.Tests;

public class TestBase
{
    protected ApplicationManager App;

    [SetUp]
    public void SetUp()
    {
        App = new ApplicationManager();
    }

    [TearDown]
    protected void TearDown()
    {
        App.Stop();
    }
}