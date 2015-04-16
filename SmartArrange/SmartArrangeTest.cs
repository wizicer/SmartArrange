using IcerSystem.FileArrange;
using NUnit.Framework;

namespace IcerTest.FileArrange
{
    [TestFixture]
    public class SmartArrangeTest
    {
        [Test]
        public void ArrageTest()
        {
            string[] fileNames = new string[] { @"E:\aa\sp1", @"E:\aa\sp-23412.231.txt", @"E:\aa\sp-23412.231(1).txt", @"E:\aa\sp-23412.231(1)(1).cmd", @"E:\aa\sp2" }; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = SmartArrange.Arrange(fileNames);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}