using SubscriptionServiceApi.Contracts;
using SubscriptionServiceApi.Exceptions;
using System;

namespace SubscriptionServiceApi.Validators
{
    public static class UserSubscriptionValidator
    {
        public static void Validate(this UserSubscription subscription)
        {
            if (subscription.SubscriptionType == "Paid" && string.IsNullOrWhiteSpace(subscription.PaymentMethod))
            {
                throw new SubscriptionPaymentException();
            }

            if (string.IsNullOrWhiteSpace(subscription.FirstName) || string.IsNullOrWhiteSpace(subscription.LastName) ||
                string.IsNullOrWhiteSpace(subscription.EmailAddress))
            {
                throw new RequiredPersonalInfoMissingException();
            }
        }
    }
}