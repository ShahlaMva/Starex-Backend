using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Starex.ViewModels
{
    public class RegisterVM
    {   [Required]
        public string UserName { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public DateTime Age { get; set; }
        public string Address { get; set; }
        [Required,StringLength(8)]
        public string CardSeria { get; set; }
        [Required,StringLength(7)]
        public string CardFinCode { get; set; }
        [Required, EmailAddress, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        [Required, DataType(DataType.Password), Compare(nameof(Password))]

        public string CheckPass { get; set; }
        [Required]
        public string Phone { get; set; }

    }
}
