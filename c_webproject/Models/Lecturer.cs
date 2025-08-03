using System.ComponentModel.DataAnnotations;

namespace c_webproject.Models
{
    public class Lecturer
    {
        [Key]
        public int RegNo { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }

    }
}
