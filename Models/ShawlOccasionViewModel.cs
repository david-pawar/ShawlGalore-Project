using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ShawlGalore.Models
{
    // This is a special view model class just for Shawl Occasion filtering while searchin.
    public class ShawlOccasionViewModel
    {
        public List<Shawl> Shawls { get; set; }   // A list of Shawl objects.
        public SelectList Occasions { get; set; }  // A SelectList for filtering by Occasion.
        public string ShawlOccasion { get; set; } // Selected Shawl Occasion.
        public string SearchString { get; set; }     // Search string for further filtering.
    }
}