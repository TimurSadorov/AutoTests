using NUnit.Framework;
using Test.Model;

namespace Test.Tests;

[TestFixture]
public class CreateListTests: TestBase    
{
    [Test]
    public void CreateList()
    {
        var list = new ListData($"name_{Guid.NewGuid()}");
        App.NavigationHelper.OpenCreateListForm();
        App.ListHelper.CreateList(list);
        
        Assert.True(App.ListHelper.HasList(list));
    }
}