
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using EcomBDDAutomation.Utils;
using TechTalk.SpecFlow;

namespace EcomBDDAutomation.RunConfigurations
{
    [Binding]
    public sealed class Hooks
    {
        private static FeatureContext _featureContext;
        private static ScenarioContext _scenarioContext;
        private static ExtentReports _extentReports;
        private static ExtentHtmlReporter _extentHtmlReporter;
        private static ExtentTest _feature;
        private static ExtentTest _scenario;

        [BeforeTestRun]
        public static void BeforeTest()
        {
            _extentHtmlReporter = new ExtentHtmlReporter(@"C:\Users\rohin.ramadass\source\repos\EcomBDDAutomation\EcomBDDAutomation\Reports\report.html");
            _extentReports = new ExtentReports();
            _extentReports.AttachReporter(_extentHtmlReporter);

        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            _featureContext = featureContext;
            _feature = _extentReports.CreateTest<Feature>(_featureContext.FeatureInfo.Title, _featureContext.FeatureInfo.Description);
        }

        [BeforeScenario]
        public static  void BeforeScenario(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _scenario = _feature.CreateNode<Scenario>(_scenarioContext.ScenarioInfo.Title, _scenarioContext.ScenarioInfo.Description);
            CommonFunctions.openBrowser();

        }


        [BeforeStep]  
        public static void BeforeStep()
        {

        }

        [AfterStep]
        public static void AfterStep()
        {
            ScenarioBlock scenarioBlock = _scenarioContext.CurrentScenarioBlock;

            switch (scenarioBlock)
            {
                case ScenarioBlock.Given:
                    if (_scenarioContext.TestError != null)
                    {
                        _scenario.CreateNode<Given>(_scenarioContext.TestError.Message + "\n" +
                            _scenarioContext.TestError.StackTrace);
                    }
                    else
                    {
                        _scenario.CreateNode<Given>(_scenarioContext.StepContext.StepInfo.Text);
                    }
                    break;
                case ScenarioBlock.When:
                    if (_scenarioContext.TestError != null)
                    {
                        _scenario.CreateNode<When>(_scenarioContext.TestError.Message + "\n" +
                            _scenarioContext.TestError.StackTrace);
                    }
                    else
                    {
                        _scenario.CreateNode<When>(_scenarioContext.StepContext.StepInfo.Text);
                    }
                    break;
                case ScenarioBlock.Then:
                    if (_scenarioContext.TestError != null)
                    {
                        _scenario.CreateNode<Then>(_scenarioContext.TestError.Message + "\n" +
                            _scenarioContext.TestError.StackTrace);
                    }
                    else
                    {
                        _scenario.CreateNode<Then>(_scenarioContext.StepContext.StepInfo.Text);
                    };
                    break;
            }
        }

        [AfterScenario]
        public static void AfterScenario()
        {
            CommonFunctions.closeBrowser();
        }

        [AfterFeature]
        public static  void AfterFeature()
        {

        }

        [AfterTestRun]
        public static void AfterTest()
        {
            _extentReports.Flush();
        }


    }
}
