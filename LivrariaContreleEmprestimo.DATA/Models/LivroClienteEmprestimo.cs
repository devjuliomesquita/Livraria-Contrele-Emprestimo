﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LivrariaContreleEmprestimo.DATA.Models
{
    [Table("Livro_Cliente_Emprestimo")]
    public partial class LivroClienteEmprestimo
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        public int LceldCliente { get; set; }
        public int LceldLivro { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime LceldDataEmprestimo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime LceldDataEntrega { get; set; }
        public bool LceldEntregue { get; set; }

        [ForeignKey("LceldCliente")]
        [InverseProperty("LivroClienteEmprestimo")]
        public virtual Cliente LceldClienteNavigation { get; set; }
        [ForeignKey("LceldLivro")]
        [InverseProperty("LivroClienteEmprestimo")]
        public virtual Livro LceldLivroNavigation { get; set; }
    }
}