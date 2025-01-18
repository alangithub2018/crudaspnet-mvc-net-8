using System.ComponentModel.DataAnnotations;

namespace CRUDASPNETCoreMVC.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Phone is required")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Cellphone is required")]
        public string CellPhone { get; set; }

        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
