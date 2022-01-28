using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
/* For using Remote Selenium WebDriver */
using OpenQA.Selenium.Remote;
using System;
using System.Threading;

[assembly: Parallelize(Workers = 5, Scope = ExecutionScope.MethodLevel)]

namespace ParallelLTSelenium
{
    [TestClass]
    public class ParallelLTTests
    {
        IWebDriver driver;

        /* Profile - https://accounts.lambdatest.com/detail/profile */
        String username = Environment.GetEnvironmentVariable("LT_USERNAME") || "user_name";
        String accesskey = Environment.GetEnvironmentVariable("LT_ACCESS_KEY") || "access_key";
        String gridURL = "@hub.lambdatest.com/wd/hub";

        DesiredCapabilities capabilities;

        [TestInitialize]
        public void setupInit()
        {
            capabilities = new DesiredCapabilities();

            capabilities.SetCapability("user", username);
            capabilities.SetCapability("accessKey", accesskey);
        }

        [DataTestMethod]
        [DataRow("chrome", "72.0", "Windows 10")]
        [DataRow("MicrosoftEdge", "18.0", "Windows 10")]
        [DataRow("Firefox", "70.0", "macOS High Sierra")]
        [DataRow("Safari", "12.0", "macOS Mojave")]

        [TestMethod]
        public void LT_ToDo_Test(String browser, String version, String os)
        {
            String itemName = "Yey, Let's add it to list";

            capabilities.SetCapability("browserName", browser);
            capabilities.SetCapability("version", version);
            capabilities.SetCapability("platform", os);
            capabilities.SetCapability("build", "LT ToDoApp using MsTest in Parallel on LambdaTest");
            capabilities.SetCapability("name", "LT ToDoApp using MsTest in Parallel on LambdaTest");

            driver = new RemoteWebDriver(new Uri("https://" + username + ":" + accesskey + gridURL), capabilities, TimeSpan.FromSeconds(2000));

            driver.Url = "https://lambdatest.github.io/sample-todo-app/";

            Assert.AreEqual("Sample page - lambdatest.com", driver.Title);
            // Click on First Check box
            IWebElement firstCheckBox = driver.FindElement(By.Name("li1"));
            firstCheckBox.Click();

            // Click on Second Check box
            IWebElement secondCheckBox = driver.FindElement(By.Name("li2"));
            secondCheckBox.Click();

            // Enter Item name
            IWebElement textfield = driver.FindElement(By.Id("sampletodotext"));
            textfield.SendKeys(itemName);

            // Click on Add button
            IWebElement addButton = driver.FindElement(By.Id("addbutton"));
            addButton.Click();

            // Verified Added Item name
            IWebElement itemtext = driver.FindElement(By.XPath("/html/body/div/div/div/ul/li[6]/span"));
            String getText = itemtext.Text;
            Assert.IsTrue(itemName.Contains(getText));

            /* Perform wait to check the output */
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine("LT_ToDo_Test Passed");
        }


        [DataTestMethod]
        [DataRow("chrome", "72.0", "Windows 10")]
        [DataRow("MicrosoftEdge", "18.0", "Windows 10")]
        [DataRow("Firefox", "70.0", "macOS High Sierra")]
        [DataRow("Safari", "12.0", "macOS Mojave")]

        [TestMethod]
        public void Google_Test_2(String browser, String version, String os)
        {
            capabilities.SetCapability("browserName", browser);
            capabilities.SetCapability("version", version);
            capabilities.SetCapability("platform", os);
            capabilities.SetCapability("geoLocation", "US");
            capabilities.SetCapability("build", "Google Search (2) using MsTest in Parallel on LambdaTest");
            capabilities.SetCapability("name", "Google Search (2) using MsTest in Parallel on LambdaTest");

            driver = new RemoteWebDriver(new Uri("https://" + username + ":" + accesskey + gridURL), capabilities, TimeSpan.FromSeconds(2000));

            driver.Url = "https://www.google.com";

            IWebElement element = driver.FindElement(By.XPath("//input[@name='q']"));

            element.SendKeys("LambdaTest");

            /* Submit the Search */
            element.Submit();

            /* Perform wait to check the output */
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine("Google_Test Passed");

        }

        [TestCleanup]
        public void Cleanup()
        {
            if (driver != null)
                driver.Quit();
        }
    }
}
