using LivrariaContreleEmprestimo.DATA.Interface;
using LivrariaContreleEmprestimo.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaContreleEmprestimo.DATA.Repositories
{
    public class RepositoryVwLivroClienteEmprestimo : RepositoryBase<VwLivroClienteEmprestimo>, IRepositoryVwLivroClienteEmprestimo
    {
        public RepositoryVwLivroClienteEmprestimo(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}
