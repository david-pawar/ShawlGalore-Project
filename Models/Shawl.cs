using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShawlGalore.Models
{
    public class Shawl
    {
        public int Id { get; set; }

        //  public string Image { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Material { get; set; }


        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Color { get; set; }


        [StringLength(60, MinimumLength = 2)]
        [Required]
        public string Design { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public string Occasion { get; set; }

        [Required]
        public string Size { get; set; }



        [Column(TypeName = "decimal(18, 2)")]
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }
}