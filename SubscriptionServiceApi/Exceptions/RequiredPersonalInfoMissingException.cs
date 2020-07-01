namespace SubscriptionServiceApi.Exceptions
{
    public class RequiredPersonalInfoMissingException : UserSubscriptionValidationException
    {
        private const string ErrorCode = "Subscription must contain FirstName, LastName and Email.";

        public RequiredPersonalInfoMissingException() : base(ErrorCode) { }
    }
}
