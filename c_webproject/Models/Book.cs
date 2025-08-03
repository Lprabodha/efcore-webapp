using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace c_webproject.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public string? Author { get; set; }

        [DisplayName("Publish")]
        public DateTime DateOfPublish { get; set; }

        [DisplayName("Date Of Relase")]
        public DateTime? DateOfRelease { get; set; }

    }
}
