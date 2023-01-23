using System.ComponentModel.DataAnnotations;

namespace webUi.Models
{
    public class ContactModel
    {
        public int  Id { get; set; }
        [Required]
        public string Mail { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Message { get; set; }
        public bool Kvkk { get; set; }
    }
}