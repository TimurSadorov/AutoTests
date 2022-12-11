using NUnit.Framework;
using Test.Model;

namespace Test.Tests;

[TestFixture]
public class TaskTests : TestBase
{
    [OneTimeSetUp]
    public void SetUpTests()
    {
        var account = new AccountData("sadorov2001@mail.ru", "hk21002001");
        
        App.NavigationHelper.OpenHomePage();
        App.AuthHelper.Login(account);
        
        var listData = new ListData($"name_{Guid.NewGuid()}");
        
        App.NavigationHelper.OpenCreateListForm();
        App.ListHelper.CreateList(listData);

        App.NavigationHelper.OpenList(listData.Name);
    }
    
    [Test]
    public void CreateTask()
    {
        var taskData = new TaskData(Guid.NewGuid().ToString());
        App.TaskHelper.AddTask(taskData);
        
        Assert.True(App.TaskHelper.HasTask(taskData));
    }

    [Test]
    public void ChangeTask()
    {
        var taskData = new TaskData(Guid.NewGuid().ToString());
        App.TaskHelper.AddTask(taskData);
        
        var newName = Guid.NewGuid().ToString();
        App.TaskHelper.ChangeName(newName);

        var changedTask = new TaskData(newName);
        Assert.True(App.TaskHelper.HasTask(changedTask));
    }
}