using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Coffee_Shop_Lab.Models
{
    public class RegisterUser
    {
        [Required] //makes this field required
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 30 characters")]
        public string Name { get; set; }

        [Required]
        //[EmailAddress]
        [RegularExpression(@"^[a-zA-Z0-9{5,30}]+@[a-zA-A0-9{5,10}]+\.[a-zA-Z0-9{2,3}]+$", ErrorMessage = "Invalid Email")]
        public string Email { get; set; }

        [Required] //makes this field required
        [StringLength(15, MinimumLength = 5, ErrorMessage = "Password must be between 5 and 15 characters")]
        public string Password { get; set; }

        [RegularExpression(@"\d{4}/\d{2}/\d{2}")]
        public DateTime DOB { get; set; }

        public bool Human { get; set; }

        public RegisterUser()
        {

        }
        public RegisterUser(string name, string email, string password, DateTime DOB)
        {
            Name = name;
            Email = email;
            Password = password;
            this.DOB = DOB;
        }
    }
}
