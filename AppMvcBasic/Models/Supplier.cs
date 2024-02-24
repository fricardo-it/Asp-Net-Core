using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace AppMvcBasic.Models;

public class Supplier : Entity
{
    [Required(ErrorMessage = "{0} is a required field.")]
    [StringLength(200, ErrorMessage = "The field {0} requires length between {2} and {1} characters.", MinimumLength = 2)]
    public string Name { get; set; }

    [Required(ErrorMessage = "{0} is a required field.")]
    [StringLength(14, ErrorMessage = "The field {0} requires length between {2} and {1} characters.", MinimumLength = 11)]
    public string Document { get; set; }

    [Required(ErrorMessage = "{0} is a required field.")]
    [StringLength(200, ErrorMessage = "The field {0} requires length between {2} and {1} characters.", MinimumLength = 6)]
    public string Email { get; set; }

    [Required(ErrorMessage = "{0} is a required field.")]
    [StringLength(10, ErrorMessage = "The field {0} requires {1} numbers.", MinimumLength = 10)]
    public string PhoneNumber { get; set; }

    public TypeSupplier TypeSupplier { get; set; }

    public Address Address { get; set; }

    [DisplayName("Active?")]
    public bool Active { get; set; }

    /* EF Relations*/
    public IEnumerable<Product> Products { get; set; }
}