using System;

namespace SpecSalad
{
    public class SaladException : Exception
    {
        public SaladException(string message) : base(message)
        {            
        }
    }
}