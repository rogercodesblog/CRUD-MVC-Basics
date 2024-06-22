using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudExample.Models;

[Table("Contacts")]
public class Contact
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "The name is required.")]
    [MaxLength(60, ErrorMessage = "The name can't have more than 60 letters.")]
    [DisplayName("Name")]
    public string Name { get; set; }
    [Required(ErrorMessage = "The phone number is required.")]
    [Phone(ErrorMessage = "The provided phone number is not valid.")]
    [DisplayName("Phone Number")]
    public string PhoneNumber { get; set; }
    [Required(ErrorMessage = "The E-Mail is required.")]
    [EmailAddress(ErrorMessage = "The provided E-Mail is not valid.")]
    [DisplayName("E-Mail")]
    public string Email { get; set; }
    [DisplayName("Date Created")]
    public DateTimeOffset DateCreated { get; set; }
}
