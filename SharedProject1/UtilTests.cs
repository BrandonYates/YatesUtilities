using System;

public class UtilTests
{
    private int runTests = 0;
    private int passingTests = 0;
    private int failingTests = 0;
    private int totalTests = 2;

    public UtilTests()
	{

        runTest(testEpochConversion());
        runTest(testDateString());

        String success = "TEST SUCCESS";
        String failure = "TEST FAILURE";

        String resultStr = (failingTests == 0) ? "TEST SUCCESS" : "TEST FAILURE";
        
        Console.WriteLine(resultStr + ": " + runTests + " of " + totalTests + " run " + failingTests + " failed");
    }


    private void runTest (Action testMethod)
    {
        try
        {
            testMethod();
            //only reachable if testMethod did not throw an exception
            passingTests++;
        }
        catch
        {
            failingTests++;
            Console.WriteLine("Test Failed: " + testMethod.ToString());
        }
        finally
        {
            runTests++;
        }
    }

    private void testEpochConversion ()
    {
        Utility utility = new UtilityImpl();

        long epoch = 0L;
        String epochStr = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        if(!utility.getDate(epoch).equals(epochStr)) {
            throw new System.FormatException();
        }
    }

    private void testDateString ()
    {
        Utility utility = new UtilityImpl();

        String testDate = new DateTime(2017, 3, 6, 0, 0, 0, DateTimeKind.Utc).ToShortDateString;
        long expectedEpoch = 1488758400000;
        long result = utility.fromDateString(testDate);
        if (result != expectedEpoch)
        {
            Console.WriteLine("incorrect epoch received: " + result.ToString);
            throw new System.FormatException();
        }


    }
}
