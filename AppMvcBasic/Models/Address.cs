using System.ComponentModel.DataAnnotations;

namespace AppMvcBasic.Models;

public class Address : Entity
{
    public Guid SupplierId { get; set; }

    [Required(ErrorMessage = "{0} is a required field.")]
    [StringLength(200, ErrorMessage = "The field {0} requires length between {2} and {1} characters.", MinimumLength = 2)]
    public string Street { get; set; }

    [Required(ErrorMessage = "{0} is a required field.")]
    [StringLength(50, ErrorMessage = "The field {0} requires length between {2} and {1} characters.", MinimumLength = 1)]
    public string Number { get; set; }

    public string Complement { get; set; }

    [Required(ErrorMessage = "{0} is a required field.")]
    [StringLength(6, ErrorMessage = "The field {0} requires only {1} characters.", MinimumLength = 6)]
    public string PostalCode { get; set; }

    [Required(ErrorMessage = "{0} is a required field.")]
    [StringLength(200, ErrorMessage = "The field {0} requires length between {2} and {1} characters.", MinimumLength = 2)]
    public string City { get; set; }

    [Required(ErrorMessage = "{0} is a required field.")]
    [StringLength(2, ErrorMessage = "The field {0} requires only {1} characters.", MinimumLength = 2)]
    public string State { get; set; }

    /* EF Relations*/
    public Supplier Supllier { get; set; }

}