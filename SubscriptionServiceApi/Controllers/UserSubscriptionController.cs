using Microsoft.AspNetCore.Mvc;
using SubscriptionServiceApi.Contracts;
using SubscriptionServiceApi.Exceptions;
using SubscriptionServiceApi.Validators;

namespace SubscriptionServiceApi.Controllers
{
    [Route("[controller]")]
    public class UserSubscriptionController : Controller
    {
        [HttpPost]
        public IActionResult Post([FromBody] UserSubscription subscription)
        {
            try
            {
                subscription.Validate();

                // call some code to create the new subscription in our database

                return new OkResult();
            }
            catch (UserSubscriptionValidationException usvx)
            {
                return new BadRequestObjectResult(usvx.Message);
            }
        }
    }
}