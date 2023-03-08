using LivrariaContreleEmprestimo.DATA.Models;

namespace LivrariaControleEmprestimo.WEB.Models
{
    public class EmprestimoViewModel
    {
        public Cliente oCliente { get; set; }
        public Livro oLivro { get; set; }
        public int oClienteId { get; set; }
        public int oLivroId { get; set; }
        public DateTime dataEntrega { get; set; }
        public DateTime dataEmprestimo { get; set; }
        public List<Cliente> oListCliente { get; set; }
        public List<Livro> oListLivro { get; set; }
    }
}
