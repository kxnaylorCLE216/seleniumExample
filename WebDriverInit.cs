using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.Remote;

namespace seleniumExample
{
  public enum BrowserType
  {
    Chrome,
    Firefox,
    Edge,
    Safari,
    Opera
  }
  public class WebDriverInit
  {
    public IWebDriver GetWebDriver(BrowserType browserType)
    {
      dynamic capability = GetBrowserOptions(browserType);

      var driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), capability);

      driver.Manage().Window.Maximize();

      return driver;

    }
    private dynamic GetBrowserOptions(BrowserType browserType)
    {
      switch (browserType)
      {
        case BrowserType.Chrome:
          return new ChromeOptions();
        case BrowserType.Firefox:
          return new FirefoxOptions();
        case BrowserType.Edge:
          return new EdgeOptions();
        case BrowserType.Opera:
          return new OperaOptions();
        default:
          throw new ArgumentOutOfRangeException(nameof(browserType), browserType, null);
      }

    }

  }
}
