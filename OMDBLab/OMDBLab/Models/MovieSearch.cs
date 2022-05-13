using System.ComponentModel.DataAnnotations;

namespace OMDBLab.Models
{
    public class MovieSearch
    {
        [Required]
        public string SearchTerm { get; set; }
    }
}
