using System;
using System.Collections.Generic;
using System.Text;

namespace YatesUtils
{
    interface Utilities
    {
        public String getDate(long epoch);

        public long fromDateString(String dateString);

        public String helloWorld();
    };
}
