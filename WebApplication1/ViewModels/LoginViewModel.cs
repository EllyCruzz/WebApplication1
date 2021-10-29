using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace WebApplication1.ViewModels
{
    public class LoginViewModel
    {
        [Required]

        public string Usuario { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
    }
}