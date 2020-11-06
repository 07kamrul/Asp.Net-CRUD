using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Full_CRUD.Models.Extended
{
    [MetadataType(typeof(EmployeeMetadata))]
    public partial class Employee
    {

    }

    public class EmployeeMetadata 
    {
        [Required (AllowEmptyStrings = false, ErrorMessage = "Please provice first name")]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please provice last name")]
        public string LastName { get; set; }
    }
}