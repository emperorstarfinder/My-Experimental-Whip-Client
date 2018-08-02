using System;
using System.Collections.Generic;
using System.Text;

namespace Enhanced.Whip.Client
{
    public class AssetProtocolError : Exception
    {
        public AssetProtocolError(string message)
            : base(message)
        {

        }

        public AssetProtocolError(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}