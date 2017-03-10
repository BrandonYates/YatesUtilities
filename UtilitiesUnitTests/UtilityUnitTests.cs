using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YatesUtilities;

namespace UtilitiesUnitTests
{
    [TestClass]
    public class UtilityUnitTests
    {
        private TestContext testContext;

        [TestMethod]
        private void testEpochConversion()
        {
            testContext.WriteLine("Running testEpochConversion...");
            YatesUtilities.Utility utility = new UtilityImpl();

            long epoch = 0L;
            String epochStr = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).ToShortDateString();

            testContext.WriteLine("epoch date string: " + epochStr);
            Assert.AreEqual(utility.getDate(epoch), epochStr);
        }

        [TestMethod]
        private void testDateString()
        {
            testContext.WriteLine("Running testDateString...");
            Utility utility = new UtilityImpl();

            String testDate = new DateTime(2017, 3, 6, 0, 0, 0, DateTimeKind.Utc).ToShortDateString();
            testContext.WriteLine("testDate: " + testDate);
            long expectedEpoch = 1488758400000;
            long result = utility.fromDateString(testDate);

            testContext.WriteLine("epoch returned: " + result.ToString());
            Assert.AreEqual(expectedEpoch, result);
        }
    }
}
