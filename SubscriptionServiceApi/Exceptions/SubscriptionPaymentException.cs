namespace SubscriptionServiceApi.Exceptions
{
    public class SubscriptionPaymentException : UserSubscriptionValidationException
    {
        private const string ErrorCode = "Invalid subscription type/payment combination.";

        public SubscriptionPaymentException() : base(ErrorCode) { }
    }
}
