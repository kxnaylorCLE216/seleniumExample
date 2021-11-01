using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;

[assembly: Parallelize(Workers = 4, Scope = ExecutionScope.MethodLevel)]

namespace seleniumExample
{
  [TestClass]
  public class UnitTest1 : WebDriverInit
  {
    public IWebDriver driver;

    [TestMethod]
    [DataRow(BrowserType.Chrome)]
    [DataRow(BrowserType.Firefox)]
    [DataRow(BrowserType.Edge)]
    public void NBA(BrowserType browserType)
    {

      using (var driver = GetWebDriver(browserType))
      {

        driver.Manage().Window.Maximize();

        driver.Navigate().GoToUrl("https://www.youtube.com/user/NBA");

        Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
        var filePath = AppDomain.CurrentDomain.BaseDirectory + System.DateTime.Now.ToShortTimeString() + ".png";
        ss.SaveAsFile(filePath);

        Assert.IsTrue(driver.PageSource.Contains("NBA"));

        driver.Quit();
      }
    }

    [TestMethod]
    [DataRow(BrowserType.Chrome)]
    [DataRow(BrowserType.Firefox)]
    [DataRow(BrowserType.Edge)]
    public void NFL(BrowserType browserType)
    {

      using (var driver = GetWebDriver(browserType))
      {

        driver.Manage().Window.Maximize();

        driver.Navigate().GoToUrl("https://www.youtube.com/user/NFL");

        Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
        var filePath = AppDomain.CurrentDomain.BaseDirectory + System.DateTime.Now.ToShortTimeString() + ".png";
        ss.SaveAsFile(filePath);

        Assert.IsTrue(driver.PageSource.Contains("NFL"));

        driver.Quit();
      }
    }

    [TestMethod]
    [DataRow(BrowserType.Chrome)]
    [DataRow(BrowserType.Firefox)]
    [DataRow(BrowserType.Edge)]
    public void MLB(BrowserType browserType)
    {

      using (var driver = GetWebDriver(browserType))
      {

        driver.Manage().Window.Maximize();

        driver.Navigate().GoToUrl("https://www.youtube.com/c/MLB");

        Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
        var filePath = AppDomain.CurrentDomain.BaseDirectory + System.DateTime.Now.ToShortTimeString() + ".png";
        ss.SaveAsFile(filePath);

        Assert.IsTrue(driver.PageSource.Contains("MLB"));

        driver.Quit();
      }
    }

    [TestMethod]
    [DataRow(BrowserType.Chrome)]
    [DataRow(BrowserType.Firefox)]
    [DataRow(BrowserType.Edge)]
    public void NHL(BrowserType browserType)
    {

      using (var driver = GetWebDriver(browserType))
      {

        driver.Manage().Window.Maximize();

        driver.Navigate().GoToUrl("https://www.youtube.com/c/NHL");

        Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
        var filePath = AppDomain.CurrentDomain.BaseDirectory + System.DateTime.Now.ToShortTimeString() + ".png";
        ss.SaveAsFile(filePath);

        Assert.IsTrue(driver.PageSource.Contains("NHL"));

        driver.Quit();
      }

    }
  }
}
