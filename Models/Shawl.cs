using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShawlGalore.Models
{
    public class Shawl
    {
        public int Id { get; set; }

        //  public string Image { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }
        public string Design { get; set; }
        public string Occasion { get; set; }
        public string Size { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}