﻿namespace Restaurants.Services.Models
{
    using System.ComponentModel.DataAnnotations;

    public class EditMealBindingModel
    {
        [Required]
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int TypeId { get; set; }
    }
}