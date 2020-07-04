using BlazorServerLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorServerLibrary.Models
{
    public class Address
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Street is required")]
        [MaxLength(100)]
        public string Street { get; set; }

        [Required(ErrorMessage = "Town / City is required")]
        [MaxLength(50)]
        public string TownCity { get; set; }

        public string Region { get; set; }

        [Required(ErrorMessage = "Post Code is required")]
        [DataType(DataType.PostalCode)]
        [MaxLength(50)]
        public string PostCode { get; set; }
    }
}
