using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YatesUtilities
{
    public class UtilityImpl : Utility
    {
        //takes milliseconds since the EPOCH and returns a string representation
        public String getDate(long unixTime)
        {
            DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

            DateTime actual = epoch.AddMilliseconds(unixTime);

            return actual.ToShortDateString();
        }

        //takes in a string and returns the milliseconds since the epoch in UTC
        public long fromDateString(String dateString)
        {
            DateTime dateTime = Convert.ToDateTime(dateString);

            return (long)dateTime.ToUniversalTime().Subtract(
                new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
        }

        //classic hello world method, mostly used for testing if the service is responding
        public String helloWorld()
        {
            return "Hello World\n";
        }
    }
}
