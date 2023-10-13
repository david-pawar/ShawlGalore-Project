using System;
using System.ComponentModel.DataAnnotations;

namespace ShawlGalore.Models
{
    public class Shawl
    {
        public int Id { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }
        public string Design { get; set; }
        public string Occasion { get; set; }
        public string Size { get; set; }
        public decimal Price { get; set; }
    }
}