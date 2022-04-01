using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderingApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculateController : ControllerBase
    {
        public List<Order> Orders = new();

        [HttpPost]
        public decimal Calculate(Order order, DateTime dateTime)
        {
            var currentHour = dateTime.Hour;
            var price = currentHour > 19
                ? (decimal) ((order.Starter.Amount * 4 + order.MainDish.Amount * 7 + order.Drinks.Amount * 2.50) * 0.9)
                : (decimal) ((order.Starter.Amount * 4 + order.MainDish.Amount * 7 + (order.Drinks.Amount * 2.50) * 0.7) * 0.9);

            return Math.Round(price, 2);
        }
    }
}