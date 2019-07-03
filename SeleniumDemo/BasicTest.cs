using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;
using System.Threading;

namespace SeleniumDemo
{
    [TestClass]
    public class BasicTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("headless");
            using (var driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), options))
            {
                driver.Navigate().GoToUrl("https://www.whatsapp.com/");

                driver.Manage().Window.Maximize();

                Thread.Sleep(5000);
            }
        }
    }
}
