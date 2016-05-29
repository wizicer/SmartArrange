namespace UnitTest
{
    using System;
    using System.Collections.Generic;
    using System.IO.Abstractions.TestingHelpers;
    using System.Linq;
    using IcerSystem.FileArrange;
    using NUnit.Framework;
    using TechTalk.SpecFlow;
    using TechTalk.SpecFlow.Assist;

    [Binding]
    public class ArrangeTestSteps
    {
        [Given(@"I have following files in the file system")]
        public static void GivenIHaveFollowingFilesInTheFileSystem(Table table)
        {
            var files = table.CreateSet<FileTable>()
                .ToDictionary(_ => _.Filename, _ => new MockFileData(string.Empty));
            var fileSystem = new MockFileSystem(files);
            ScenarioContext.Current.Set(fileSystem);
        }

        [Given(@"I have following files to be arranged")]
        public static void GivenIHaveFollowingFilesToBeArranged(Table table)
        {
            var files = table.CreateSet<FileTable>();
            ScenarioContext.Current.Set(files);
        }

        [When(@"I start smart arrange")]
        public static void WhenIStartSmartArrange()
        {
            var fileSystem = ScenarioContext.Current.Get<MockFileSystem>();
            var files = ScenarioContext.Current.Get<IEnumerable<FileTable>>();
            var sa = new SmartArrange(fileSystem);
            sa.Arrange(files.Select(_ => _.Filename).ToArray());
        }

        [Then(@"the result should be")]
        public static void ThenTheResultShouldBe(Table table)
        {
            var expectFiles = table.CreateSet<FileTable>()
                .Select(_ => _.Filename)
                .ToArray();
            var fileSystem = ScenarioContext.Current.Get<MockFileSystem>();
            var files = fileSystem.AllPaths;
            CollectionAssert.AreEquivalent(expectFiles, files);
        }

        private class FileTable
        {
            public string Filename { get; set; }
        }
    }
}