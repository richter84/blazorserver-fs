using BlazorServerLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorServerLibrary.Models
{
    public class Address : IAddress
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Street is required")]
        public string Street { get; set; }

        [Required(ErrorMessage = "Town / City is required")]
        public string TownCity { get; set; }

        public string Region { get; set; }

        [Required(ErrorMessage = "Post Code is required")]
        [DataType(DataType.PostalCode)]
        public string PostCode { get; set; }
    }
}
