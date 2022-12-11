using NUnit.Framework;
using Test.Model;

namespace Test.Tests;

public class AuthBase: TestBase
{
    [OneTimeSetUp]
    public void OneTimeSetUpAuth()
    {
        var account = new AccountData("sadorov2001@mail.ru", "hk21002001");
        App.AuthHelper.Login(account);
    }
}