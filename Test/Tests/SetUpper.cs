using NUnit.Framework;

namespace Test.Tests;

[SetUpFixture]
public class SetUpper
{
    [OneTimeTearDown]
    public void TearDown()
    {
        ApplicationManager.App.Stop();
    }
}