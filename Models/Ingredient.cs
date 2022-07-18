﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace la_mia_pizzeria_static.Models
{
    [Table("Ingredient")]
    public class Ingredient
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        
        public List<Pizza> Pizzas { get; set; }
    }
}
