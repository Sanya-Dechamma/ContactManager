using System.ComponentModel.DataAnnotations;

namespace GTSLQP_ContactManager.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Category name is required.")]
        public string CategoryName { get; set; }

        // Navigation property
        public ICollection<Contact> Contacts { get; set; }
    }
}
