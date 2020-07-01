using System;

namespace SubscriptionServiceApi.Contracts
{
    public class UserSubscription
    {
        public string AccountNumber { get; set; }
        public bool IsActive { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string SubscriptionType { get; set; }
        public string PaymentMethod { get; set; }
        public DateTime ExpirationDate { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastRenewedDate { get; set; }
    }
}
