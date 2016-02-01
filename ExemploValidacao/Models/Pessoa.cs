using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ExemploValidacao.Models
{
    public class Pessoa
    {
        [Required(ErrorMessage = "Nome deve ser preenchido")]
        public string Nome { get; set; }

        [StringLength(50, MinimumLength =5, ErrorMessage = "A observação deve ter entre 5 e 50 caracteres")]
        [Required(ErrorMessage = "Observacão deve ser preenchida")]
        public string Observacao { get; set; }

        [Range(18,50, ErrorMessage = "A idade da pessoa deve ser entre 18 e 50 anos")]
        public int Idade { get; set; }

        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")]
        public string Email { get; set; }

        [Remote("LoginUnico", "Pessoa", ErrorMessage = "Este nome de login já existe")]
        [RegularExpression(@"[a-zA-z]{5,15}", ErrorMessage = "Login deve possuir somente letras e entre 5 a 15 caracteres")]
        [Required(ErrorMessage = "O login deve ser preenchido")]
        public string Login { get; set; }

        [Required(ErrorMessage = "A senha deve ser informada")]
        public string Senha { get; set; }

        [System.ComponentModel.DataAnnotations.Compare("Senha", ErrorMessage = "As senhas não conferem")]
        public string ConfirmarSenha { get; set; }
    }
}
