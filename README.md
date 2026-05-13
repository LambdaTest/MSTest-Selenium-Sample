# Run Selenium Tests With MSTest — TestMu AI (Formerly LambdaTest)

![image](https://user-images.githubusercontent.com/70570645/171443386-68376fc1-489e-4930-9186-07a30de636ce.png)

<p align="center">
  <a href="https://www.testmuai.com/blog/?utm_source=github&utm_medium=repo&utm_campaign=MSTest-Selenium-Sample" target="_bank">Blog</a>
  &nbsp; &#8901; &nbsp;
  <a href="https://www.testmuai.com/support/docs/?utm_source=github&utm_medium=repo&utm_campaign=MSTest-Selenium-Sample" target="_bank">Docs</a>
  &nbsp; &#8901; &nbsp;
  <a href="https://www.testmuai.com/learning-hub/?utm_source=github&utm_medium=repo&utm_campaign=MSTest-Selenium-Sample" target="_bank">Learning Hub</a>
  &nbsp; &#8901; &nbsp;
  <a href="https://www.testmuai.com/newsletter/?utm_source=github&utm_medium=repo&utm_campaign=MSTest-Selenium-Sample" target="_bank">Newsletter</a>
  &nbsp; &#8901; &nbsp;
  <a href="https://www.testmuai.com/certifications/?utm_source=github&utm_medium=repo&utm_campaign=MSTest-Selenium-Sample" target="_bank">Certifications</a>
  &nbsp; &#8901; &nbsp;
  <a href="https://www.youtube.com/@TestMuAI" target="_bank">YouTube</a>
</p>
&emsp;
&emsp;
&emsp;

*Learn how to use MSTest framework to configure and run your C# automation testing scripts on the TestMu AI platform*

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

**Step 1:** Clone the TestMu AI’s MSTest-Selenium-Sample repository and navigate to the code directory as shown below:

```csharp
git clone https://github.com/LambdaTest/MSTest-Selenium-Sample
cd MSTest-Selenium-Sample
```
### Setting up Your Authentication 
Make sure you have your TestMu AI credentials with you to run test automation scripts with C# on TestMu AI Selenium Grid. You can get these credentials from the [TestMu AI Automation Dashboard](https://automation.lambdatest.com/login?utm_source=github&utm_medium=repo&utm_campaign=MSTest-Selenium-Sample) or by your TestMu AI Profile.

**Step 2:** Set TestMu AI Username and Access Key in environment variables.

 **For Linux/macOS**:
 
 `export LT_USERNAME="YOUR_USERNAME" export LT_ACCESS_KEY="YOUR ACCESS KEY"`
 
 **For Windows**:
 
 `set LT_USERNAME="YOUR_USERNAME" set LT_ACCESS_KEY="YOUR ACCESS KEY"`

## Run Your First Test 

>**Test Scenario**: This MSTest Selenium script tests a sample to-do list app by marking couple items as done, adding a new item to the list and finally displaying the count of pending items as output.

**Step 3:** Check out the [LocalMSTest.cs](https://github.com/LambdaTest/MSTest-Selenium-Sample/blob/main/src/test/LocalMSTest.cs) file for sample test case.

### Configuration of Your Test Capabilities

**Step 4:** In the test script, you need to update your test capabilities. In this code, we are passing browser, browser version, and operating system information, along with TestMu AI Selenium grid capabilities via capabilities object. The capabilities object in the above code are defined as:

```csharp
DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability(CapabilityType.BrowserName, "Chrome");
            capabilities.SetCapability(CapabilityType.Version, "96");
            capabilities.SetCapability(CapabilityType.Platform, "Windows 10");
```

**Note:** You can generate capabilities for your test requirements with the help of **[Desired Capabilitiy Generator](https://www.testmuai.com/capabilities-generator/?utm_source=github&utm_medium=repo&utm_campaign=MSTest-Selenium-Sample)**.

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
Your results would be displayed on the test console and on the TestMu AI Automation Dashboard.

## Running Your Parallel Tests Using MSTest Testing Framework

To run parallel tests, open Visual Studio and go to **Test Explorer** and then click on **Run All** tests to execute the tests. Your results would be displayed on the test console and on the TestMu AI Automation Dashboard.

## Testing Locally Hosted Or Privately Hosted Projects

You can test your locally hosted or privately hosted projects with TestMu AI Selenium grid using TestMu AI Tunnel. All you would have to do is set up an SSH tunnel using tunnel and pass toggle `tunnel = True` via desired capabilities. TestMu AI Tunnel establishes a secure SSH protocol based tunnel that allows you in testing your locally hosted or privately hosted pages, even before they are live.

Refer our [TestMu AI Tunnel documentation](https://www.testmuai.com/support/docs/testing-locally-hosted-pages/?utm_source=github&utm_medium=repo&utm_campaign=MSTest-Selenium-Sample) for more information.

Here’s how you can establish TestMu AI Tunnel.

Download the binary file of:
* [TestMu AI Tunnel for Windows](https://downloads.lambdatest.com/tunnel/v3/windows/64bit/LT_Windows.zip)
* [TestMu AI Tunnel for macOS](https://downloads.lambdatest.com/tunnel/v3/mac/64bit/LT_Mac.zip)
* [TestMu AI Tunnel for Linux](https://downloads.lambdatest.com/tunnel/v3/linux/64bit/LT_Linux.zip)

Open command prompt and navigate to the binary folder.

Run the following command:

```bash
LT --user {user’s login email} --key {user’s access key}
```
So if your user name is lambdatest@example.com and key is 123456, the command would be:

```bash
LT --user lambdatest@example.com --key 123456
```
Once you are able to connect **TestMu AI Tunnel** successfully, you would just have to pass on tunnel capabilities in the code shown below :

**Tunnel Capability**

```java
DesiredCapabilities capabilities = new DesiredCapabilities();        
        capabilities.setCapability("tunnel", true);
```
## Additional Links

* [Advanced Configuration for Capabilities](https://www.testmuai.com/support/docs/selenium-automation-capabilities/?utm_source=github&utm_medium=repo&utm_campaign=MSTest-Selenium-Sample)
* [How to test locally hosted apps](https://www.testmuai.com/support/docs/testing-locally-hosted-pages/?utm_source=github&utm_medium=repo&utm_campaign=MSTest-Selenium-Sample)
* [How to integrate TestMu AI with CI/CD](https://www.testmuai.com/support/docs/integrations-with-ci-cd-tools/?utm_source=github&utm_medium=repo&utm_campaign=MSTest-Selenium-Sample)

## Tutorials 📙

Check out our latest tutorials on MSTest automation testing 👇

* [NUnit vs. XUnit vs. MSTest: Comparing Unit Testing Frameworks In C#](https://www.testmuai.com/blog/nunit-vs-xunit-vs-mstest/?utm_source=github&utm_medium=repo&utm_campaign=MSTest-Selenium-Sample)
* [Selenium MSTest Tutorial: Setup Selenium WebDriver For MSTest Framework In C#](https://www.testmuai.com/blog/setting-selenium-webdriver-for-mstest/?utm_source=github&utm_medium=repo&utm_campaign=MSTest-Selenium-Sample)
* [Most Complete MSTest Framework Tutorial Using .Net Core](https://www.testmuai.com/blog/most-complete-mstest-framework-tutorial-using-net-core-2/?utm_source=github&utm_medium=repo&utm_campaign=MSTest-Selenium-Sample)
* [MSTest Tutorial: Parameterized Tests For Selenium Testing](https://www.testmuai.com/blog/mstest-tutorial-parameterized-tests-for-selenium-testing/?utm_source=github&utm_medium=repo&utm_campaign=MSTest-Selenium-Sample)
* [MSTest‌ ‌Tutorial:‌ ‌Running‌ ‌First‌ ‌Selenium‌ ‌Automation‌ ‌Script‌](https://www.testmuai.com/blog/mstest-tutorial-running-first-selenium-automation-script/?utm_source=github&utm_medium=repo&utm_campaign=MSTest-Selenium-Sample)
* [MSTest Tutorial: Environment Setup For Selenium Testing](https://www.testmuai.com/blog/mstest-tutorial-environment-setup-for-selenium-testing/?utm_source=github&utm_medium=repo&utm_campaign=MSTest-Selenium-Sample)

For video tutorials on Selenium MSTest, please refer to our [MSTest Tutorial Playlist](https://www.youtube.com/playlist?list=PLZMWkkQEwOPlT7o9t3IN162KY3eG7K7TN). ▶️

Subscribe To Our [TestMu AI YouTube Channel 🔔](https://www.youtube.com/@TestMuAI) and keep up-to-date on the latest video tutorial around software testing world.

## Documentation & Resources :books:

      
Visit the following links to learn more about TestMu AI's features, setup and tutorials around test automation, mobile app testing, responsive testing, and manual testing.

* [TestMu AI Documentation](https://www.testmuai.com/support/docs/?utm_source=github&utm_medium=repo&utm_campaign=MSTest-Selenium-Sample)
* [TestMu AI Blog](https://www.testmuai.com/blog/?utm_source=github&utm_medium=repo&utm_campaign=MSTest-Selenium-Sample)
* [TestMu AI Learning Hub](https://www.testmuai.com/learning-hub/?utm_source=github&utm_medium=repo&utm_campaign=MSTest-Selenium-Sample)    

## TestMu AI Community :busts_in_silhouette:

The [TestMu AI Community](https://community.testmuai.com/?utm_source=github&utm_medium=repo&utm_campaign=MSTest-Selenium-Sample) allows people to interact with tech enthusiasts. Connect, ask questions, and learn from tech-savvy people. Discuss best practises in web development, testing, and DevOps with professionals from across the globe 🌎

## What's New At TestMu AI ❓

To stay updated with the latest features and product add-ons, visit [Changelog](https://changelog.lambdatest.com/)

## 🚀 LambdaTest is Now TestMu AI

👋 Welcome to TestMu AI, the next evolution of LambdaTest. As of January 2026, [LambdaTest is Now TestMu AI](https://www.testmuai.com/lambdatest-is-now-testmuai/) - we have evolved from a cross-browser testing cloud into a unified, AI-native quality engineering platform designed for the modern DevOps era.

Whether you have been part of the LambdaTest community for years or are just discovering TestMu AI, our mission remains the same: to help you ship faster with high-scale test execution, autonomous testing, and deep quality analytics.

### 🔄 Our Rebrand Journey

In 2017, we introduced LambdaTest with a clear mission: to become the world's most trusted cloud testing platform. We built a scalable, high-performance test cloud that eliminated flakiness, improved developer feedback cycles, and accelerated release velocity for teams worldwide.

As LambdaTest grew, we expanded the platform into Test Intelligence, Visual Regression Testing, Accessibility Testing, API Testing, and Performance Testing, covering the entire testing lifecycle. These capabilities enabled teams to test any stack, on any technology, at enterprise scale.

Over time, we rebuilt the architecture to be AI-native from the ground up. What began as LambdaTest's high-performance testing cloud has now evolved into TestMu AI, an AI-native, multi-agent platform redefining modern quality engineering.

We chose the name TestMu AI to reflect our shift towards intelligent, autonomous testing. While our identity has changed, our core technology and commitment to the testing community stay the same.

👉 Find [LambdaTest's New Home](https://www.testmuai.com/).

### 🔭 Explore TestMu AI

The same infrastructure LambdaTest customers relied on, now delivered through autonomous AI agents.

- [KaneAI](https://www.testmuai.com/kane-ai/)
- [Agent-to-Agent Testing](https://www.testmuai.com/agent-to-agent-testing/)
- [HyperExecute](https://www.testmuai.com/hyperexecute/)
- [Real Device Cloud](https://www.testmuai.com/real-device-cloud/)
- [Pricing](https://www.testmuai.com/pricing/)
- [Documentation](https://www.testmuai.com/support/docs/)