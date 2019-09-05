using System.ComponentModel.DataAnnotations;

namespace DellChallenge.D2.Web.Models
{
    public class NewProductModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        public string Category { get; set; }
    }
}
