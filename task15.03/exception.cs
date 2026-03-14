using System;
using System.Collections.Generic;
using System.Text;

namespace task15._03
{
    public class PriceMustBeGreaterThanZeroException : Exception
    {
        public PriceMustBeGreaterThanZeroException(string message) : base(message)
        {

        }
    }
}
        
    

