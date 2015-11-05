using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Restaurants.Services.Models
{
    using System.ComponentModel.DataAnnotations;

    public class CreateRestaurantBindingModel
    {
        [Required]
        public string Name { get; set; }

        public int TownId { get; set; }
    }
}