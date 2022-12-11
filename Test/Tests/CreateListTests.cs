using System.Text.Json;
using NUnit.Framework;
using Test.Model;

namespace Test.Tests;

[TestFixture]
public class CreateListTests: TestBase    
{
    [Test]
    [TestCaseSource(nameof(GenerateListData))]
    public void CreateList(ListData listData)
    {
        var account = new AccountData("sadorov2001@mail.ru", "hk21002001");
        
        App.NavigationHelper.OpenHomePage();
        App.AuthHelper.Login(account);
        
        App.NavigationHelper.OpenCreateListForm();
        App.ListHelper.CreateList(listData);
        
        Assert.True(App.ListHelper.HasList(listData));
    }
    
    private static IEnumerable<ListData> GenerateListData()
    {
        var json = File.ReadAllText( 
            @"C:\Programming\Development\Repositories\AutoTests\Generator\Data\lists.json");
        return JsonSerializer.Deserialize<List<ListData>>(json)
               ?? throw new AggregateException("Can't get lists");
    }
}