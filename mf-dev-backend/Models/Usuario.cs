﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Obrigatório Informar o Nome")]
        public string Nome { get; set; }
        [Required(ErrorMessage ="Obrigatório Informar a Senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        [Required(ErrorMessage ="Obrigatório informar o Pefil")]
        public Perfil Perfil { get; set; }

    }

    public enum Perfil
    {
        Admin,
        User
    }
}
