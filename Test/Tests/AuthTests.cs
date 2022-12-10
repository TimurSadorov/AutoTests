using NUnit.Framework;
using Test.Model;

namespace Test.Tests;

[TestFixture]
public class AuthTests: TestBase    
{
    [Test]
    public void Auth()
    {
        var account = new AccountData("sadorov2001@mail.ru", "hk21002001");
        
        App.NavigationHelper.OpenHomePage();
        App.AuthHelper.Login(account);
    }
}