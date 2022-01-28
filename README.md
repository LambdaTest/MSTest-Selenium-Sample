# MSTest Selenium Sample

![MSTest](https://www.lambdatest.com/resources/images/meta/MSTest.jpg)

## Prerequisites

1. Setup Visual Studio with .NET core.
   1.Download Visual studio from [Visual Studio website](https://visualstudio.microsoft.com/downloads/)
   2.Install the framework 'Microsoft.NETCore.App' [here](https://dotnet.microsoft.com/en-us/download/dotnet/3.0/runtime).
   3.For more refference, refer [MSTest Blog](https://www.lambdatest.com/blog/most-complete-mstest-framework-tutorial-using-net-core-2/).

## Steps to Run your First Test

Step 1. Clone the WD Selenium Repository.

```
git clone https://github.com/LambdaTest/MSTest-Selenium-Sample.git
```

Step 2. Inside mstest-selenium-sample, export the Lambda-test Credentials. You can get these from your automation dashboard.

<p align="center">
   <b>For Linux/macOS:</b>
   
```
export LT_USERNAME="YOUR_USERNAME"
export LT_ACCESS_KEY="YOUR ACCESS KEY"
```
<p align="center">
   <b>For Windows:</b>
```
set LT_USERNAME="YOUR_USERNAME"
set LT_ACCESS_KEY="YOUR ACCESS KEY"
```

Step 3. To run your First Test.

```
dotnet test MS-Test-Cross-Browser.csproj
```

## See the Results

You can check your test results on the [Automation Dashboard](https://automation.lambdatest.com/build).
![Automation Testing Logs](https://www.lambdatest.com/blog/wp-content/uploads/2020/04/automation-output-nightwatch.png)

## About LambdaTest

[LambdaTest](https://www.lambdatest.com/) is a cloud based selenium grid infrastructure that can help you run automated cross browser compatibility tests on 2000+ different browser and operating system environments. LambdaTest supports all programming languages and frameworks that are supported with Selenium, and have easy integrations with all popular CI/CD platforms. It's a perfect solution to bring your [selenium automation testing](https://www.lambdatest.com/selenium-automation) to cloud based infrastructure that not only helps you increase your test coverage over multiple desktop and mobile browsers, but also allows you to cut down your test execution time by running tests on parallel.
