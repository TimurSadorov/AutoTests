using NUnit.Framework;
using Test.Model;

namespace Test.Tests;

[TestFixture]
public class CreateListTests: TestBase    
{
    [Test]
    public void CreateList()
    {
        var account = new AccountData("sadorov2001@mail.ru", "hk21002001");
        
        App.NavigationHelper.OpenHomePage();
        App.AuthHelper.Login(account);
        
        var list = new ListData($"name_{Guid.NewGuid()}");
        App.NavigationHelper.OpenCreateListForm();
        App.ListHelper.CreateList(list);
        
        Assert.True(App.ListHelper.HasList(list));
    }
}