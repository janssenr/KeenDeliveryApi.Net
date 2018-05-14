using System;

namespace KeenDeliveryApi.Net.Errors
{
    public class KeenDeliveryException : Exception
    {
        public KeenDeliveryException(string message) : base(message) { }
    }
}
