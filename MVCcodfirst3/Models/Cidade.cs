using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCcodfirst3.Models
{
    public class Cidade
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CidadeId { get; set; }
        [Required]
        [Display(Name = "Cidade")]
        //[Remote("CheckUserExist", "Cidade", ErrorMessage = "The User Exists")]
        public string NomeCidade { get; set; }

        public virtual ICollection<Pessoa> Pessoa_cid { get; set; }
    }
}