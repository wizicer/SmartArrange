﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace UnitTest
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("ArrangeTest")]
    public partial class ArrangeTestFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ArrangeTest.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ArrangeTest", "\tIn order to avoid silly mistakes\r\n\tAs a user\r\n\tI want to be told the result of s" +
                    "mart arrange.", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Standard example")]
        public virtual void StandardExample()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Standard example", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Filename"});
            table1.AddRow(new string[] {
                        "E:\\aa\\sp1"});
            table1.AddRow(new string[] {
                        "E:\\aa\\sp-23412.231.txt"});
            table1.AddRow(new string[] {
                        "E:\\aa\\sp-23412.231(1).txt"});
            table1.AddRow(new string[] {
                        "E:\\aa\\sp-23412.231(1)(1).cmd"});
            table1.AddRow(new string[] {
                        "E:\\aa\\sp2"});
#line 7
 testRunner.Given("I have following files in the file system", ((string)(null)), table1, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Filename"});
            table2.AddRow(new string[] {
                        "E:\\aa\\sp-23412.231.txt"});
            table2.AddRow(new string[] {
                        "E:\\aa\\sp-23412.231(1).txt"});
            table2.AddRow(new string[] {
                        "E:\\aa\\sp-23412.231(1)(1).cmd"});
#line 14
 testRunner.Given("I have following files to be arranged", ((string)(null)), table2, "Given ");
#line 19
 testRunner.When("I start smart arrange", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Filename"});
            table3.AddRow(new string[] {
                        "E:\\aa\\sp1"});
            table3.AddRow(new string[] {
                        "E:\\aa\\p-23412.231\\sp-23412.231.txt"});
            table3.AddRow(new string[] {
                        "E:\\aa\\p-23412.231\\sp-23412.231(1).txt"});
            table3.AddRow(new string[] {
                        "E:\\aa\\p-23412.231\\sp-23412.231(1)(1).cmd"});
            table3.AddRow(new string[] {
                        "E:\\aa\\sp2"});
            table3.AddRow(new string[] {
                        "E:\\aa\\p-23412.231\\"});
            table3.AddRow(new string[] {
                        "E:\\aa\\"});
            table3.AddRow(new string[] {
                        "E:\\"});
#line 20
 testRunner.Then("the result should be", ((string)(null)), table3, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("chinese example")]
        public virtual void ChineseExample()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("chinese example", ((string[])(null)));
#line 31
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Filename"});
            table4.AddRow(new string[] {
                        "X:\\Movies\\007系列之23 天幕杀机 Skyfall.2012.BluRay.720p.x264.AC3-WOFEI.mkv"});
            table4.AddRow(new string[] {
                        "X:\\Movies\\007系列之20 择日再死 Die.Another.Day.2002.BluRay.720p.x264.AC3-WOFEI.mkv"});
            table4.AddRow(new string[] {
                        "X:\\Movies\\007系列之19 黑日危机 The.World.Is.Not.Enough.1999.BluRay.720p.x264.AC3-WOFEI.m" +
                            "kv"});
            table4.AddRow(new string[] {
                        "X:\\Movies\\007系列之22 量子危机 Quantum.Of.Solace.2008.BluRay.720p.x264.AC3-WOFEI.mkv"});
            table4.AddRow(new string[] {
                        "X:\\Movies\\007系列之21 皇家赌场 Casino.Royale.2006.BluRay.720p.x264.AC3-WOFEI.mkv"});
            table4.AddRow(new string[] {
                        "X:\\Movies\\007系列之16 杀人执照 Licence.to.Kill.1989.BluRay.720p.x264.AC3-WOFEI.mkv"});
            table4.AddRow(new string[] {
                        "X:\\Movies\\007系列之14 雷霆杀机 A.View.to.a.Kill.1985.BluRay.720p.x264.AC3-WOFEI.mkv"});
            table4.AddRow(new string[] {
                        "X:\\Movies\\007系列之13 八爪女 Octopussy.1983.BluRay.720p.x264.AC3-WOFEI.mkv"});
            table4.AddRow(new string[] {
                        "X:\\Movies\\007系列之15 黎明生机 The.Living.Daylights.1987.BluRay.720p.x264.AC3-WOFEI.mkv"});
            table4.AddRow(new string[] {
                        "X:\\Movies\\007系列之17 黄金眼 GoldenEye.1995.BluRay.720p.x264.AC3-WOFEI.mkv"});
            table4.AddRow(new string[] {
                        "X:\\Movies\\007系列之12 最高机密 For.Your.Eyes.Only.1981.BluRay.720p.x264.AC3-WOFEI.mkv"});
            table4.AddRow(new string[] {
                        "X:\\Movies\\007系列之11 太空城 Moonraker.1979.BluRay.720p.x264.AC3-WOFEI.mkv"});
            table4.AddRow(new string[] {
                        "X:\\Movies\\007系列之10 海底城 The.Spy.Who.Loved.Me.1977.BluRay.720p.x264.AC3-WOFEI.mkv"});
            table4.AddRow(new string[] {
                        "X:\\Movies\\007系列之18 明日帝国 Tomorrow.Never.Dies.1997.BluRay.720p.x264.AC3-WOFEI.mkv"});
#line 32
 testRunner.Given("I have following files in the file system", ((string)(null)), table4, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Filename"});
            table5.AddRow(new string[] {
                        "X:\\Movies\\007系列之23 天幕杀机 Skyfall.2012.BluRay.720p.x264.AC3-WOFEI.mkv"});
            table5.AddRow(new string[] {
                        "X:\\Movies\\007系列之20 择日再死 Die.Another.Day.2002.BluRay.720p.x264.AC3-WOFEI.mkv"});
            table5.AddRow(new string[] {
                        "X:\\Movies\\007系列之19 黑日危机 The.World.Is.Not.Enough.1999.BluRay.720p.x264.AC3-WOFEI.m" +
                            "kv"});
            table5.AddRow(new string[] {
                        "X:\\Movies\\007系列之22 量子危机 Quantum.Of.Solace.2008.BluRay.720p.x264.AC3-WOFEI.mkv"});
            table5.AddRow(new string[] {
                        "X:\\Movies\\007系列之21 皇家赌场 Casino.Royale.2006.BluRay.720p.x264.AC3-WOFEI.mkv"});
            table5.AddRow(new string[] {
                        "X:\\Movies\\007系列之16 杀人执照 Licence.to.Kill.1989.BluRay.720p.x264.AC3-WOFEI.mkv"});
            table5.AddRow(new string[] {
                        "X:\\Movies\\007系列之14 雷霆杀机 A.View.to.a.Kill.1985.BluRay.720p.x264.AC3-WOFEI.mkv"});
            table5.AddRow(new string[] {
                        "X:\\Movies\\007系列之13 八爪女 Octopussy.1983.BluRay.720p.x264.AC3-WOFEI.mkv"});
            table5.AddRow(new string[] {
                        "X:\\Movies\\007系列之15 黎明生机 The.Living.Daylights.1987.BluRay.720p.x264.AC3-WOFEI.mkv"});
            table5.AddRow(new string[] {
                        "X:\\Movies\\007系列之17 黄金眼 GoldenEye.1995.BluRay.720p.x264.AC3-WOFEI.mkv"});
            table5.AddRow(new string[] {
                        "X:\\Movies\\007系列之12 最高机密 For.Your.Eyes.Only.1981.BluRay.720p.x264.AC3-WOFEI.mkv"});
            table5.AddRow(new string[] {
                        "X:\\Movies\\007系列之11 太空城 Moonraker.1979.BluRay.720p.x264.AC3-WOFEI.mkv"});
            table5.AddRow(new string[] {
                        "X:\\Movies\\007系列之10 海底城 The.Spy.Who.Loved.Me.1977.BluRay.720p.x264.AC3-WOFEI.mkv"});
            table5.AddRow(new string[] {
                        "X:\\Movies\\007系列之18 明日帝国 Tomorrow.Never.Dies.1997.BluRay.720p.x264.AC3-WOFEI.mkv"});
#line 48
 testRunner.Given("I have following files to be arranged", ((string)(null)), table5, "Given ");
#line 64
 testRunner.When("I start smart arrange", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Filename"});
            table6.AddRow(new string[] {
                        "X:\\Movies\\.BluRay.720p.x264.AC3-WOFEI\\007系列之23 天幕杀机 Skyfall.2012.BluRay.720p.x264" +
                            ".AC3-WOFEI.mkv"});
            table6.AddRow(new string[] {
                        "X:\\Movies\\.BluRay.720p.x264.AC3-WOFEI\\007系列之20 择日再死 Die.Another.Day.2002.BluRay.7" +
                            "20p.x264.AC3-WOFEI.mkv"});
            table6.AddRow(new string[] {
                        "X:\\Movies\\.BluRay.720p.x264.AC3-WOFEI\\007系列之19 黑日危机 The.World.Is.Not.Enough.1999." +
                            "BluRay.720p.x264.AC3-WOFEI.mkv"});
            table6.AddRow(new string[] {
                        "X:\\Movies\\.BluRay.720p.x264.AC3-WOFEI\\007系列之22 量子危机 Quantum.Of.Solace.2008.BluRay" +
                            ".720p.x264.AC3-WOFEI.mkv"});
            table6.AddRow(new string[] {
                        "X:\\Movies\\.BluRay.720p.x264.AC3-WOFEI\\007系列之21 皇家赌场 Casino.Royale.2006.BluRay.720" +
                            "p.x264.AC3-WOFEI.mkv"});
            table6.AddRow(new string[] {
                        "X:\\Movies\\.BluRay.720p.x264.AC3-WOFEI\\007系列之16 杀人执照 Licence.to.Kill.1989.BluRay.7" +
                            "20p.x264.AC3-WOFEI.mkv"});
            table6.AddRow(new string[] {
                        "X:\\Movies\\.BluRay.720p.x264.AC3-WOFEI\\007系列之14 雷霆杀机 A.View.to.a.Kill.1985.BluRay." +
                            "720p.x264.AC3-WOFEI.mkv"});
            table6.AddRow(new string[] {
                        "X:\\Movies\\.BluRay.720p.x264.AC3-WOFEI\\007系列之13 八爪女 Octopussy.1983.BluRay.720p.x26" +
                            "4.AC3-WOFEI.mkv"});
            table6.AddRow(new string[] {
                        "X:\\Movies\\.BluRay.720p.x264.AC3-WOFEI\\007系列之15 黎明生机 The.Living.Daylights.1987.Blu" +
                            "Ray.720p.x264.AC3-WOFEI.mkv"});
            table6.AddRow(new string[] {
                        "X:\\Movies\\.BluRay.720p.x264.AC3-WOFEI\\007系列之17 黄金眼 GoldenEye.1995.BluRay.720p.x26" +
                            "4.AC3-WOFEI.mkv"});
            table6.AddRow(new string[] {
                        "X:\\Movies\\.BluRay.720p.x264.AC3-WOFEI\\007系列之12 最高机密 For.Your.Eyes.Only.1981.BluRa" +
                            "y.720p.x264.AC3-WOFEI.mkv"});
            table6.AddRow(new string[] {
                        "X:\\Movies\\.BluRay.720p.x264.AC3-WOFEI\\007系列之11 太空城 Moonraker.1979.BluRay.720p.x26" +
                            "4.AC3-WOFEI.mkv"});
            table6.AddRow(new string[] {
                        "X:\\Movies\\.BluRay.720p.x264.AC3-WOFEI\\007系列之10 海底城 The.Spy.Who.Loved.Me.1977.BluR" +
                            "ay.720p.x264.AC3-WOFEI.mkv"});
            table6.AddRow(new string[] {
                        "X:\\Movies\\.BluRay.720p.x264.AC3-WOFEI\\007系列之18 明日帝国 Tomorrow.Never.Dies.1997.BluR" +
                            "ay.720p.x264.AC3-WOFEI.mkv"});
            table6.AddRow(new string[] {
                        "X:\\Movies\\.BluRay.720p.x264.AC3-WOFEI\\"});
            table6.AddRow(new string[] {
                        "X:\\Movies\\"});
            table6.AddRow(new string[] {
                        "X:\\"});
#line 65
 testRunner.Then("the result should be", ((string)(null)), table6, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
