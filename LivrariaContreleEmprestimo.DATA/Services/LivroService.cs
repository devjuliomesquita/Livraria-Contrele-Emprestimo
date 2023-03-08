using LivrariaContreleEmprestimo.DATA.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaContreleEmprestimo.DATA.Services
{
    public class LivroService
    {
        public RepositoryLivro oRepositoryLivro { get; set; }
        public LivroService()
        {
            oRepositoryLivro= new RepositoryLivro();
        }
    }
}
