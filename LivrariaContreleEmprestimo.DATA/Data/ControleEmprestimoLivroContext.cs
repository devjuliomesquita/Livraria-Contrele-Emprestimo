﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using LivrariaContreleEmprestimo.DATA.Models;

namespace LivrariaContreleEmprestimo.DATA.Data
{
    public partial class ControleEmprestimoLivroContext : DbContext
    {
        public ControleEmprestimoLivroContext()
        {
        }

        public ControleEmprestimoLivroContext(DbContextOptions<ControleEmprestimoLivroContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Livro> Livro { get; set; }
        public virtual DbSet<LivroClienteEmprestimo> LivroClienteEmprestimo { get; set; }
        public virtual DbSet<VwLivroClienteEmprestimo> VwLivroClienteEmprestimo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=MOBTEC-185;Initial Catalog=ControleEmprestimoLivro;User ID=sa;Password=Jcam@1507");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LivroClienteEmprestimo>(entity =>
            {
                entity.HasOne(d => d.LceldClienteNavigation)
                    .WithMany(p => p.LivroClienteEmprestimo)
                    .HasForeignKey(d => d.LceldCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Livro_Cliente_Emprestimo_Cliente");

                entity.HasOne(d => d.LceldLivroNavigation)
                    .WithMany(p => p.LivroClienteEmprestimo)
                    .HasForeignKey(d => d.LceldLivro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Livro_Cliente_Emprestimo_Livro");
            });

            modelBuilder.Entity<VwLivroClienteEmprestimo>(entity =>
            {
                entity.ToView("VW_Livro_Cliente_Emprestimo");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}