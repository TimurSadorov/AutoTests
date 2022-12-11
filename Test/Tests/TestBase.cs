using NUnit.Framework;

namespace Test.Tests;

public class TestBase
{
    protected ApplicationManager App;

    [OneTimeSetUp]
    public void SetUp()
    {
        App = ApplicationManager.App;
    }
}