using BlazorServerLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorServerLibrary.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters.")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Email Address")]
        [EmailAddress(ErrorMessage = "Email Address is not valid")]
        [MaxLength(100)]
        public string EmailAddress { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Phone Number cannot contain letters A-Z")]
        [MaxLength(50)]
        //[Phone(ErrorMessage = "Phone Number is not valid"]
        public string PhoneNumber { get; set; }
        public ICollection<Address> Address { get; set; }

        public Customer()
        {
            Address = new List<Address>();
        }
    }
}
