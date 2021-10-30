using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationForChallenge.Models
{

    public class Estabelecimento
    {
        [HiddenInput] //Define tipo de campo como hidden
      
        public int Codigo { get; set; }
        
        [Display(Name = "Nome Fantasia")]
        [Required, MaxLength(120)]
        public string Nome { get; set; }

        [Display(Name = "CNPJ")]
        [Required, MaxLength(14)]
        public string Cnpj { get; set; }
        
        [Display(Name = "Razão Social")]
        [Required(ErrorMessage = "Razão Social é obrigatório"), StringLength(100, MinimumLength = 3, ErrorMessage = "{0} inválido, deve ter entre {2} e {1} caracteres")]
        public string RazaoSocial { get; set; }

        [Display(Name = "Ramo de Atuação")]
        public string Ramo { get; set; }

        [Display(Name = "Porte")]
        public Porte Porte { get; set; }

        [DataType(DataType.Date), Display(Name = "Data de Abertura")]
 
        public DateTime DataAbertura { get; set; }

        //1:1
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        //1:1
        public string Telefone { get; set; }

    }

    public enum Porte
    {        
        Pequeno, Medio, Grande
    }

}
