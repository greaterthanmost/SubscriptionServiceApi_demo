using System;

namespace SubscriptionServiceApi.Exceptions
{
    public class UserSubscriptionValidationException : Exception
    {
        public UserSubscriptionValidationException() { }

        public UserSubscriptionValidationException(string message) : base(message) { }

        public UserSubscriptionValidationException(string message, Exception innerException) : base(message, innerException) { }
    }
}