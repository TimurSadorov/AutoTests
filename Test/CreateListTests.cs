using NUnit.Framework;

namespace Test;

[TestFixture]
public class CreateListTests: TestBase    
{
    [Test]
    public void Auth()
    {
        var account = new AccountData("sadorov2001@mail.ru", "hk21002001");
        OpenHomePage();
        Login(account);
        var list = new ListData($"name_{new Guid()}");
        CreateList(list);
    }
}