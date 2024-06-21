using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudExample.Models;

[Table("Contacts")]
public class Contact
{
    [Key]
    public int Id { get; set; }
    [Required]
    [DisplayName("Name")]
    public string Name { get; set; }
    [Required]
    [DisplayName("Phone Number")]
    public string PhoneNumber { get; set; }
    [Required]
    [EmailAddress]
    [DisplayName("E-Mail")]
    public string Email { get; set; }
    [DisplayName("Date Added")]
    public DateTimeOffset DateCreated { get; set; }
}
