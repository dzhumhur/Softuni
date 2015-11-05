using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Restaurants.Services.Models
{
    public class CreateOrderBindingModel
    {
        public int MealId { get; set; }

        public int Quantity { get; set; }


        public string OrderStatus { get; set; }

        public DateTime CreatedOn { get; set; }

    }
}