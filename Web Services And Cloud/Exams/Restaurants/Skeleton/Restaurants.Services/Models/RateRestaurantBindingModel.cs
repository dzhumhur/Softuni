namespace Restaurants.Services.Models
{
    using System.ComponentModel.DataAnnotations;

    public class RateRestaurantBindingModel
    {
        [Required]
        [Range(1,10)]
        public int Rate { get; set; }
    }
}