using System.ComponentModel.DataAnnotations;

namespace mainBookBlogMvc.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please fill the required filed!")]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please fill the required filed!")]
        [MaxLength(50)]
        [Display(Name = "Author name")]
        public string AuthorName { get; set; }

        [Required(ErrorMessage = "Please fill the required filed!")]
        [MaxLength(50)]
        public string Publisher { get; set; }

        [Required(ErrorMessage = "Please fill the required filed!")]
        public string Description { get; set; }
        public bool InSlider { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
