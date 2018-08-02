using System;
using System.Collections.Generic;
using System.Text;

namespace Enhanced.Whip.Client
{
    public class AuthException : Exception
    {
        public AuthException(string message) : base(message)
        {
            
        }
    }
}
