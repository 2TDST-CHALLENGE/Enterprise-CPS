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
        public string Nome { get; set; }

        [Display(Name = "CNPJ")]
        public string Cnpj { get; set; }
        
        [Display(Name = "Razão Social")]        
        public string RazaoSocial { get; set; }

        [Display(Name = "Ramo de Atuação")]
        public string Ramo { get; set; }
        public Porte Porte { get; set; }

        [DataType(DataType.Date), Display(Name = "Data de Abertura")]
        public DateTime DataAbertura { get; set; }

        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        public string Telefone { get; set; }

    }

    public enum Porte
    {        
        Pequeno, Medio, Grande
    }

}
