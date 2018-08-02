﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Enhanced.Whip.Client
{
    public class AssetServerError : Exception
    {
        public AssetServerError(string message) : base(message)
        {
         
        }

        public AssetServerError(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
