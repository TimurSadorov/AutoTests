using NUnit.Framework;
using Test.Configuration;
using Test.Model;

namespace Test.Tests;

[TestFixture]
public class LoginTests: TestBase    
{
    [Test]
    public void LoginWithValidData()
    {
        var account = new AccountData(Settings.Email, Settings.Password);
        
        App.AuthHelper.Logout();
        App.AuthHelper.Login(account);

        Assert.True(App.AuthHelper.IsLoggedIn());
    }
    
    [Test]
    public void LoginWithInvalidData()
    {
        var account = new AccountData("mail@mail.ru", "111");
        
        App.AuthHelper.Logout();
        App.AuthHelper.Login(account);

        Assert.False(App.AuthHelper.IsLoggedIn());
    }
}