﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace OnlineStoreAPI.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int stockQuantity { get; set; }
        [ForeignKey("Category")]
        public int  CategoryId { get; set; }
       
        public DateTime CreatedAt { get; set; }

        [NotMapped]
        public Category Category { get; set; }
    }
}
