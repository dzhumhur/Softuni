namespace Restaurants.Services.Models
{
    using System.ComponentModel.DataAnnotations;

    public class AddMealBindingModel
    {
        [Required]
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int TypeId { get; set; }

        [Required]
        public int RestaurantId { get; set; }

    }
}