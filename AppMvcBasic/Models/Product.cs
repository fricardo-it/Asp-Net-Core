using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppMvcBasic.Models;

public class Product : Entity
{
    public Guid SupplierId { get; set; }

    [Required(ErrorMessage = "{0} is a required field.")]
    [StringLength(200, ErrorMessage = "The field {0} requires length between {2} and {1} characters.", MinimumLength = 2)]
    public string Name { get; set; }

    [Required(ErrorMessage = "{0} is a required field.")]
    [StringLength(1000, ErrorMessage = "The field {0} requires length between {2} and {1} characters.", MinimumLength = 2)]
    public string Description { get; set; }

    [Required(ErrorMessage = "{0} is a required field.")]
    [StringLength(200, ErrorMessage = "The field {0} requires length between {2} and {1} characters.", MinimumLength = 2)]
    public string Image { get; set; }

    public decimal Amount { get; set; }

    public DateTime RegisterDate { get; set; }

    [DisplayName("Active?")]
    public bool Active { get; set; }

    /* EF Relations*/
    public Supplier Supllier { get; set; }
}