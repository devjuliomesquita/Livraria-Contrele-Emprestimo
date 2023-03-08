using LivrariaContreleEmprestimo.DATA.Models;
using LivrariaContreleEmprestimo.DATA.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaContreleEmprestimo.DATA.Services
{
    public class LivroClienteEmprestimoService
    {
        public RepositoryVwLivroClienteEmprestimo oRepositoryVwLivroClienteEmprestimo { get; set; }
        public RepositoryCliente oRepositoryCliente { get; set; }
        public RepositoryLivro oRepositoryLivro { get; set; }
        public RepositoryLivroClienteEmprestimo oRepositoryLivroClienteEmprestimo { get; set; }
        public LivroClienteEmprestimoService()
        {
            oRepositoryVwLivroClienteEmprestimo = new RepositoryVwLivroClienteEmprestimo();
            oRepositoryCliente = new RepositoryCliente();
            oRepositoryLivro= new RepositoryLivro();
            oRepositoryLivroClienteEmprestimo = new RepositoryLivroClienteEmprestimo();
        }
    }
}
