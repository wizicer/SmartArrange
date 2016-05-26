namespace UnitTest
{
    using System;
    using System.Linq;
    using IcerSystem.FileArrange;
    using NUnit.Framework;
    using TechTalk.SpecFlow;
    using TechTalk.SpecFlow.Assist;

    [Binding]
    public class ArrangeTestSteps
    {
        [Given(@"I have following files to be arranged")]
        public static void GivenIHaveFollowingFilesToBeArranged(Table table)
        {
            ScenarioContext.Current.Set(table, "FileTable");
        }

        [When(@"I start smart arrange")]
        public static void WhenIStartSmartArrange()
        {
            var table = ScenarioContext.Current.Get<Table>("FileTable");
            var files = table.Rows.Select(_ => _["Filename"]).ToArray();
            var output = CommonStringExtension.GetCommonSubstring(files);
            ScenarioContext.Current.Set(output, "ArrangeResult");

        }

        [Then(@"the result should be `(.*)`")]
        public static void ThenTheResultShouldBe(string path)
        {
            var output = ScenarioContext.Current.Get<string>("ArrangeResult");
            Assert.AreEqual(path, output);
        }

    }
}
