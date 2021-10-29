using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;


namespace WebApplication1.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage =
            "Números e caracteres especiais não são permitidos no usuário.")]
        public string Usuario { get; set; }
        [Required]

        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirme Senha")]
        [Compare("Senha", ErrorMessage = "Senha e confirmação de senha não conferem.")]
        public string ConfirmeSenha { get; set; }
    }

}