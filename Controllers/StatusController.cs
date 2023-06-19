using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SubscriptionManager.Models;

namespace SubscriptionManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscriptionController : ControllerBase
    {
        public static List<Subscription> list = new List<Subscription>();

        [HttpGet]
        public List<Subscription> GetSubscription()
        {
            return list;
        }

        [HttpPost]
        public string PostSubscription(Subscription subscription)
        {
            list.Add(subscription);
            return "Added Subscription Information";
        }

        [HttpDelete]
        public IActionResult DeleteSubscription(Subscription subscription)
        {
            Subscription subscriptionAux = list.FirstOrDefault(x => x.Status == subscription.Status);

            if (subscriptionAux != null)
            {
                list.Remove(subscriptionAux);
                return Ok("Removed Subscription Information");
            }

            return BadRequest("Invalid Subscription");
        }
    }
}
