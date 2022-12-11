using OpenQA.Selenium;
using Test.Model;

namespace Test.Helpers;

public class LoginHelper: HelperBase
{
    public LoginHelper(IWebDriver driver) : base(driver)
    {
    }

    public void Login(AccountData account)
    {
        if (IsLogin())
        {
            return;
        }
        
        Driver.FindElement(By.LinkText("Войти")).Click();
        Driver.FindElement(By.Id("emailOrPhone")).SendKeys(account.Email);
        Driver.FindElement(By.Id("password")).Click();
        Driver.FindElement(By.Id("password")).SendKeys(account.Password);
        Driver.FindElement(By.CssSelector(".button__3eXSs")).Click();
        Thread.Sleep(10000);
    }
    
    public bool IsLogin()
    { 
        return Driver.FindElements(By.Id("tl-bar-user")).Any();
    }
}