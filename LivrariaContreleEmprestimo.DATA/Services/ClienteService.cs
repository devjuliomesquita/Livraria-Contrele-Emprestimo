using LivrariaContreleEmprestimo.DATA.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaContreleEmprestimo.DATA.Services
{
    public class ClienteService
    {
        public RepositoryCliente oRepositoryCliente { get; set; }
        public ClienteService()
        {
            oRepositoryCliente = new RepositoryCliente();
        }
    }
}
