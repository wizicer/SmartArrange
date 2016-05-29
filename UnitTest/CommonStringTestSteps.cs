namespace UnitTest
{
    using System;
    using System.Linq;
    using IcerSystem.FileArrange;
    using NUnit.Framework;
    using TechTalk.SpecFlow;

    [Binding]
    public class CommonStringTestSteps
    {
        [Given(@"I have following strings: (.*)")]
        public static void GivenIHaveFollowingStrings(string strs)
        {
            var list = strs.Split(new[] { "^" }, StringSplitOptions.RemoveEmptyEntries);
            ScenarioContext.Current.Set(list);
        }

        [When(@"I start to find common string")]
        public static void WhenIStartToFindCommonString()
        {
            var strs = ScenarioContext.Current.Get<string[]>();
            var str = CommonStringExtension.GetCommonSubstring(strs);
            ScenarioContext.Current.Set(str, "ArrangeResult");
        }

        [Then(@"the result should be `(.*)`")]
        public static void ThenTheResultShouldBe(string result)
        {
            var output = ScenarioContext.Current.Get<string>("ArrangeResult");
            Assert.AreEqual(result, output);
        }
    }
}