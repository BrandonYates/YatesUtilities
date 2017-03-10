using System;

public class UtilTests
{
	public UtilTests()
	{
        int runTests = 0;
        int passingTests = 0;
        int failingTests = 0;
        int totalTests = 3;

        try
        {
            testEpochConversion();
            //only reachable if testEpochConversion did not throw an exception
            passingTests++;
        }
        catch
        {
            failingTests++;
            Console.WriteLine("Test Epoch Conversion Failed");
        }
        finally
        {
            runTests++;
        }

        try
        {
            testEpochConversion();
            //only reachable if testEpochConversion did not throw an exception
            passingTests++;
        }
        catch
        {
            failingTests++;
            Console.WriteLine("Test Epoch Conversion Failed");
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
        String testDate = new DateTime(2017, 3, 6, 0, 0, 0, DateTimeKind.Utc).ToShortDateString;

        
    }
}
