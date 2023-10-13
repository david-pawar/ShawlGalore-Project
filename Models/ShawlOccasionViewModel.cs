using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ShawlGalore.Models
{
    public class ShawlOccasionViewModel
    {
        public List<Shawl> Shawls { get; set; }
        public SelectList Occasions { get; set; }
        public string ShawlOccasion { get; set; }
        public string SearchString { get; set; }
    }
}