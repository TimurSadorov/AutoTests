using NUnit.Framework;

namespace Test;

[TestFixture]
public class AuthTests: TestBase    
{
    [Test]
    public void Auth()
    {
        var account = new AccountData("sadorov2001@mail.ru", "hk21002001");
        
        OpenHomePage();
        Login(account);
    }
}