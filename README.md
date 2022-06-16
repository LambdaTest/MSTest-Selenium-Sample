# Run Selenium Tests With MSTest On LambdaTest

![image](https://user-images.githubusercontent.com/70570645/171443386-68376fc1-489e-4930-9186-07a30de636ce.png)

<p align="center">
  <a href="https://www.lambdatest.com/blog/?utm_source=github&utm_medium=repo&utm_campaign=MSTest-Selenium-Sample" target="_bank">Blog</a>
  &nbsp; &#8901; &nbsp;
  <a href="https://www.lambdatest.com/support/docs/?utm_source=github&utm_medium=repo&utm_campaign=MSTest-Selenium-Sample" target="_bank">Docs</a>
  &nbsp; &#8901; &nbsp;
  <a href="https://www.lambdatest.com/learning-hub/?utm_source=github&utm_medium=repo&utm_campaign=MSTest-Selenium-Sample" target="_bank">Learning Hub</a>
  &nbsp; &#8901; &nbsp;
  <a href="https://www.lambdatest.com/newsletter/?utm_source=github&utm_medium=repo&utm_campaign=MSTest-Selenium-Sample" target="_bank">Newsletter</a>
  &nbsp; &#8901; &nbsp;
  <a href="https://www.lambdatest.com/certifications/?utm_source=github&utm_medium=repo&utm_campaign=MSTest-Selenium-Sample" target="_bank">Certifications</a>
  &nbsp; &#8901; &nbsp;
  <a href="https://www.youtube.com/c/LambdaTest" target="_bank">YouTube</a>
</p>
&emsp;
&emsp;
&emsp;

*Learn how to use MSTest framework to configure and run your C# automation testing scripts on the LambdaTest platform*

[<img height="58" width="200" src="https://user-images.githubusercontent.com/70570645/171866795-52c11b49-0728-4229-b073-4b704209ddde.png">](https://accounts.lambdatest.com/register?utm_source=github&utm_medium=repo&utm_campaign=MSTest-Selenium-Sample)

## Table Of Contents

* [Pre-requisites](#pre-requisites)
* [Run Your First Test](#run-your-first-test)
* [Parallel Testing With MSTest](#running-your-parallel-tests-using-mstest-testing-framework)
* [Local Testing With MSTest](#testing-locally-hosted-or-privately-hosted-projects)

## Prerequisites

Before you can start performing **MSTest** automation testing with **Selenium**, you would need to:

* Download and Install **Selenium WebDriver** from its [official website](https://www.selenium.dev/downloads/).
* Make sure you have latest version of C#.
* **.Net** framework to deliver guidelines while developing a range of application using C#.
* Download [Selenium WebDriver Language Binding](https://www.selenium.dev/downloads/) for C# and extract them to appropriate folder.
* A [.NET Core SDK](https://dotnet.microsoft.com/en-us/download) of 3.0.0.

### Installing Selenium Dependencies And Tutorial Repo

**Step 1:** Clone the LambdaTest’s MSTest-Selenium-Sample repository and navigate to the code directory as shown below:

```csharp
git clone https://github.com/LambdaTest/MSTest-Selenium-Sample
cd MSTest-Selenium-Sample
```
### Setting up Your Authentication 
Make sure you have your LambdaTest credentials with you to run test automation scripts with C# on LambdaTest Selenium Grid. You can get these credentials from the [LambdaTest Automation Dashboard](https://automation.lambdatest.com/login?utm_source=github&utm_medium=repo&utm_campaign=MSTest-Selenium-Sample) or by your LambdaTest Profile.

**Step 2:** Set LambdaTest Username and Access Key in environment variables.

 **For Linux/macOS**:
 
 `export LT_USERNAME="YOUR_USERNAME" export LT_ACCESS_KEY="YOUR ACCESS KEY"`
 
 **For Windows**:
 
 `set LT_USERNAME="YOUR_USERNAME" set LT_ACCESS_KEY="YOUR ACCESS KEY"`

## Run Your First Test 

>**Test Scenario**: This MSTest Selenium script tests a sample to-do list app by marking couple items as done, adding a new item to the list and finally displaying the count of pending items as output.

**Step 3:** Check out the [LocalMSTest.cs](https://github.com/LambdaTest/MSTest-Selenium-Sample/blob/main/src/test/LocalMSTest.cs) file for sample test case.

### Configuration of Your Test Capabilities

**Step 4:** In the test script, you need to update your test capabilities. In this code, we are passing browser, browser version, and operating system information, along with LambdaTest Selenium grid capabilities via capabilities object. The capabilities object in the above code are defined as:

```csharp
DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability(CapabilityType.BrowserName, "Chrome");
            capabilities.SetCapability(CapabilityType.Version, "96");
            capabilities.SetCapability(CapabilityType.Platform, "Windows 10");
```

**Note:** You can generate capabilities for your test requirements with the help of **[Desired Capabilitiy Generator](https://www.lambdatest.com/capabilities-generator/?utm_source=github&utm_medium=repo&utm_campaign=MSTest-Selenium-Sample)**.

### Executing The Test

**Step 5:** Build the solution by clicking in **Build > Build Solution.** 

**Step 6:** As shown below click on **Test Explorer** on your MS Visual Studio:

<img height="200" src="https://user-images.githubusercontent.com/70570645/171441281-5e3534e5-85d1-476a-a7b6-6f82b44df229.png"/>

**Step 7:** Click on **Run** from the Test Explorer to run the sample test as shown below:

<img height="200" src="https://user-images.githubusercontent.com/70570645/171441574-a64c9eba-2c15-430d-bfdb-34f2e08c198f.png"/>

**Executing in Linux/macOS:**

```csharp
dotnet test MS-Test-Cross-Browser.csproj
```
Your results would be displayed on the test console and on the LambdaTest Automation Dashboard.

## Running Your Parallel Tests Using MSTest Testing Framework

To run parallel tests, open Visual Studio and go to **Test Explorer** and then click on **Run All** tests to execute the tests. Your results would be displayed on the test console and on the LambdaTest Automation Dashboard.

## Testing Locally Hosted Or Privately Hosted Projects

You can test your locally hosted or privately hosted projects with LambdaTest Selenium grid using LambdaTest Tunnel. All you would have to do is set up an SSH tunnel using tunnel and pass toggle `tunnel = True` via desired capabilities. LambdaTest Tunnel establishes a secure SSH protocol based tunnel that allows you in testing your locally hosted or privately hosted pages, even before they are live.

Refer our [LambdaTest Tunnel documentation](https://www.lambdatest.com/support/docs/testing-locally-hosted-pages/?utm_source=github&utm_medium=repo&utm_campaign=MSTest-Selenium-Sample) for more information.

Here’s how you can establish LambdaTest Tunnel.

Download the binary file of:
* [LambdaTest Tunnel for Windows](https://downloads.lambdatest.com/tunnel/v3/windows/64bit/LT_Windows.zip)
* [LambdaTest Tunnel for macOS](https://downloads.lambdatest.com/tunnel/v3/mac/64bit/LT_Mac.zip)
* [LambdaTest Tunnel for Linux](https://downloads.lambdatest.com/tunnel/v3/linux/64bit/LT_Linux.zip)

Open command prompt and navigate to the binary folder.

Run the following command:

```bash
LT --user {user’s login email} --key {user’s access key}
```
So if your user name is lambdatest@example.com and key is 123456, the command would be:

```bash
LT --user lambdatest@example.com --key 123456
```
Once you are able to connect **LambdaTest Tunnel** successfully, you would just have to pass on tunnel capabilities in the code shown below :

**Tunnel Capability**

```java
DesiredCapabilities capabilities = new DesiredCapabilities();        
        capabilities.setCapability("tunnel", true);
```
## Additional Links

* [Advanced Configuration for Capabilities](https://www.lambdatest.com/support/docs/selenium-automation-capabilities/?utm_source=github&utm_medium=repo&utm_campaign=MSTest-Selenium-Sample)
* [How to test locally hosted apps](https://www.lambdatest.com/support/docs/testing-locally-hosted-pages/?utm_source=github&utm_medium=repo&utm_campaign=MSTest-Selenium-Sample)
* [How to integrate LambdaTest with CI/CD](https://www.lambdatest.com/support/docs/integrations-with-ci-cd-tools/?utm_source=github&utm_medium=repo&utm_campaign=MSTest-Selenium-Sample)

## Tutorials 📙

Check out our latest tutorials on MSTest automation testing 👇

* [NUnit vs. XUnit vs. MSTest: Comparing Unit Testing Frameworks In C#](https://www.lambdatest.com/blog/nunit-vs-xunit-vs-mstest/?utm_source=github&utm_medium=repo&utm_campaign=MSTest-Selenium-Sample)
* [Selenium MSTest Tutorial: Setup Selenium WebDriver For MSTest Framework In C#](https://www.lambdatest.com/blog/setting-selenium-webdriver-for-mstest/?utm_source=github&utm_medium=repo&utm_campaign=MSTest-Selenium-Sample)
* [Most Complete MSTest Framework Tutorial Using .Net Core](https://www.lambdatest.com/blog/most-complete-mstest-framework-tutorial-using-net-core-2/?utm_source=github&utm_medium=repo&utm_campaign=MSTest-Selenium-Sample)
* [MSTest Tutorial: Parameterized Tests For Selenium Testing](https://www.lambdatest.com/blog/mstest-tutorial-parameterized-tests-for-selenium-testing/?utm_source=github&utm_medium=repo&utm_campaign=MSTest-Selenium-Sample)
* [MSTest‌ ‌Tutorial:‌ ‌Running‌ ‌First‌ ‌Selenium‌ ‌Automation‌ ‌Script‌](https://www.lambdatest.com/blog/mstest-tutorial-running-first-selenium-automation-script/?utm_source=github&utm_medium=repo&utm_campaign=MSTest-Selenium-Sample)
* [MSTest Tutorial: Environment Setup For Selenium Testing](https://www.lambdatest.com/blog/mstest-tutorial-environment-setup-for-selenium-testing/?utm_source=github&utm_medium=repo&utm_campaign=MSTest-Selenium-Sample)

For video tutorials on Selenium MSTest, please refer to our [MSTest Tutorial Playlist](https://www.youtube.com/playlist?list=PLZMWkkQEwOPlT7o9t3IN162KY3eG7K7TN). ▶️

Subscribe To Our [LambdaTest YouTube Channel 🔔](https://www.youtube.com/c/LambdaTest) and keep up-to-date on the latest video tutorial around software testing world.

## Documentation & Resources :books:

      
Visit the following links to learn more about LambdaTest's features, setup and tutorials around test automation, mobile app testing, responsive testing, and manual testing.

* [LambdaTest Documentation](https://www.lambdatest.com/support/docs/?utm_source=github&utm_medium=repo&utm_campaign=MSTest-Selenium-Sample)
* [LambdaTest Blog](https://www.lambdatest.com/blog/?utm_source=github&utm_medium=repo&utm_campaign=MSTest-Selenium-Sample)
* [LambdaTest Learning Hub](https://www.lambdatest.com/learning-hub/?utm_source=github&utm_medium=repo&utm_campaign=MSTest-Selenium-Sample)    

## LambdaTest Community :busts_in_silhouette:

The [LambdaTest Community](https://community.lambdatest.com/?utm_source=github&utm_medium=repo&utm_campaign=MSTest-Selenium-Sample) allows people to interact with tech enthusiasts. Connect, ask questions, and learn from tech-savvy people. Discuss best practises in web development, testing, and DevOps with professionals from across the globe 🌎

## What's New At LambdaTest ❓

To stay updated with the latest features and product add-ons, visit [Changelog](https://changelog.lambdatest.com/) 
      
## About LambdaTest

[LambdaTest](https://www.lambdatest.com?utm_source=github&utm_medium=repo&utm_campaign=MSTest-Selenium-Sample) is a leading test execution and orchestration platform that is fast, reliable, scalable, and secure. It allows users to run both manual and automated testing of web and mobile apps across 3000+ different browsers, operating systems, and real device combinations. Using LambdaTest, businesses can ensure quicker developer feedback and hence achieve faster go to market. Over 500 enterprises and 1 Million + users across 130+ countries rely on LambdaTest for their testing needs.    

### Features

* Run Selenium, Cypress, Puppeteer, Playwright, and Appium automation tests across 3000+ real desktop and mobile environments.
* Real-time cross browser testing on 3000+ environments.
* Test on Real device cloud
* Blazing fast test automation with HyperExecute
* Accelerate testing, shorten job times and get faster feedback on code changes with Test At Scale.
* Smart Visual Regression Testing on cloud
* 120+ third-party integrations with your favorite tool for CI/CD, Project Management, Codeless Automation, and more.
* Automated Screenshot testing across multiple browsers in a single click.
* Local testing of web and mobile apps.
* Online Accessibility Testing across 3000+ desktop and mobile browsers, browser versions, and operating systems.
* Geolocation testing of web and mobile apps across 53+ countries.
* LT Browser - for responsive testing across 50+ pre-installed mobile, tablets, desktop, and laptop viewports

    
[<img height="58" width="200" src="https://user-images.githubusercontent.com/70570645/171866795-52c11b49-0728-4229-b073-4b704209ddde.png">](https://accounts.lambdatest.com/register?utm_source=github&utm_medium=repo&utm_campaign=MSTest-Selenium-Sample)

      
## We are here to help you :headphones:

* Got a query? we are available 24x7 to help. [Contact Us](mailto:support@lambdatest.com)
* For more info, visit - [LambdaTest](https://www.lambdatest.com/?utm_source=github&utm_medium=repo&utm_campaign=MSTest-Selenium-Sample)

