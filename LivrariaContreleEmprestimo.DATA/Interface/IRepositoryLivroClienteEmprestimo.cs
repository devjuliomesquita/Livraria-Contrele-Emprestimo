using LivrariaContreleEmprestimo.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaContreleEmprestimo.DATA.Interface
{
    public interface IRepositoryLivroClienteEmprestimo : IRepositoryModel<LivroClienteEmprestimo>, IDisposable
    {
    }
}
