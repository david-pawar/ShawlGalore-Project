using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;    //using directories for the file

namespace ShawlGalore.Models
{
    public class Shawl
    {
        public int Id { get; set; }                 //property

        //  public string Image { get; set; }
        [StringLength(60, MinimumLength = 3)]       //it will make sure that no entry should be less than three letters in strength
        [Required]                                   /// it makes sure cant be left empty,
        public string Material { get; set; }       // anothere property


        [StringLength(60, MinimumLength = 3)]       // data validation and filling this one is also mandatory
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



        [Column(TypeName = "decimal(18, 2)")]     // this file has propeprties of Shawl class and its data validation code, which will make sure that certain type of data get added in database
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }
}