using System.ComponentModel.DataAnnotations;

namespace RazorPages.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 3)]
        public string ProductNo { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 3)]
        public string ProductName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string Type { get; set; }

        [Required]
        [Range(1, 1000000)]
        [DataType(DataType.Currency)]
        public int Price { get; set; }
        
        [DataType(DataType.Date)]
        [Display(Name = "Publication Date")]
        public DateTime PublicationDate { get; set; }

        public string Rating { get; set; } = string.Empty;

    }
}
