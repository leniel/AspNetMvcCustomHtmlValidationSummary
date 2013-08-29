using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspNetMvcCustomHtmlValidationSummary.ViewModels
{
public class UserViewModel
{
    [Required]
    [StringLength(16)]
    public string Name { get; set; }

    [Required]
    [Range(18, 65)]
    public int? Age { get; set; }
}
}