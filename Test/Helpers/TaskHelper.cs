using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using Test.Model;

namespace Test.Helpers;

public class TaskHelper : HelperBase
{
    public TaskHelper(IWebDriver driver) : base(driver)
    {
    }

    public void AddTask(TaskData taskData)
    {
        Driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div[1]/div[1]/div[1]")).Click();
        Driver.FindElement(By.CssSelector(".cm-s-default textarea")).SendKeys(taskData.Name);
        new Actions(Driver)
            .KeyDown(Keys.Enter)
            .Perform();
        Thread.Sleep(1000);
    }

    public void ChangeName(string newName)
    {
        var actions = new Actions(Driver);
        actions.Click(Driver
            .FindElement(
                By.XPath("/html/body/div[2]/div/div[3]/div[2]/div/div/div[2]/div/div/div[1]/div[1]/div/div[1]/div/div/div[6]/div[1]/div/div/div"))
            )
            .KeyDown(Keys.Control)
            .SendKeys("a")
            .KeyUp(Keys.Control)
            .SendKeys(Keys.Backspace)
            .Build()
            .Perform();
        Driver.FindElement(By.CssSelector(".pastable-focus")).SendKeys(newName);
        
        Thread.Sleep(1000);
    }

    public bool HasTask(TaskData taskData)
    {
        var taskList = Driver.FindElement(By.Id("task-list-content"));
        return taskList.FindElements(By.ClassName("title"))
            .Any(element => element.Text == taskData.Name);
    }
}