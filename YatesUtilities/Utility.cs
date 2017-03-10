using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YatesUtilities
{ 
    public interface Utility
    {
        String getDate(long epoch);

        long fromDateString(String dateString);

        String helloWorld();
    };
}
