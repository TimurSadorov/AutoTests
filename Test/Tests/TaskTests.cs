using System.Text.Json;
using NUnit.Framework;
using Test.Model;

namespace Test.Tests;

[TestFixture]
public class TaskTests : AuthBase
{
    private ListData _listData = null!;
    
    [OneTimeSetUp]
    public void OneTimeSetUpTaskTests()
    {
        _listData = new ListData($"name_{Guid.NewGuid()}");

        App.NavigationHelper.OpenCreateListForm();
        App.ListHelper.CreateList(_listData);

        App.NavigationHelper.OpenList(_listData.Name);
    }
    
    [SetUp]
    public void SetUpTaskTests()
    {
        App.NavigationHelper.OpenList(_listData.Name);
    }
    
    [Test]
    [TestCaseSource(nameof(GenerateTaskData))]
    public void CreateTask(TaskData taskData)
    {
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
    
    private static IEnumerable<TaskData> GenerateTaskData()
    {
        var json = File.ReadAllText( 
            @"C:\Programming\Development\Repositories\AutoTests\Generator\Data\tasks.json");
        return JsonSerializer.Deserialize<List<TaskData>>(json)
               ?? throw new AggregateException("Can't get tasks");
    }
}