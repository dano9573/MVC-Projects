using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ACME.Models
{
    [MetadataType(typeof(Product.Metadata))]
    public partial class ProductMetadata
    {
       sealed class Metadata
        {
            [Key]
            public System.Guid ProductId { get; set; }

            [Required(ErrorMessage ="This is a custom message")]  //throws error if not valid
            [Display(Name="Product Name")]
            [StringLength(10)]
            public string Name { get; set; }

            [Required]
            [RegularExpression(@"^\$?\d+(\.(d{2}))?$")]
            //[Range(0.01, 1000.0)]  //replaces the products controller line 58 if statement.
            public decimal Price { get; set; }
        } 
    }
}