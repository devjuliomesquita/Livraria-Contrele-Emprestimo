using LivrariaContreleEmprestimo.DATA.Models;
using LivrariaContreleEmprestimo.DATA.Services;
using LivrariaControleEmprestimo.WEB.Models;
using Microsoft.AspNetCore.Mvc;

namespace LivrariaControleEmprestimo.WEB.Controllers
{
    public class EmprestimoController : Controller
    {
        private LivroClienteEmprestimoService _emprestimoService = new LivroClienteEmprestimoService();
        private EmprestimoViewModel oEmprestimoViewModel = new EmprestimoViewModel();
        public EmprestimoController(EmprestimoViewModel _EmprestimoViewModel)
        {
            oEmprestimoViewModel = _EmprestimoViewModel;
        }
        
        public IActionResult Index()
        {
            List<VwLivroClienteEmprestimo> oListVwLivroClienteEmprestimos = _emprestimoService.oRepositoryVwLivroClienteEmprestimo.SelecionarTodos();
            return View(oListVwLivroClienteEmprestimos);
        }
        public IActionResult Create()
        {
            EmprestimoViewModel oEmprestimoViewModel = new EmprestimoViewModel();
            List<Cliente> oListCliente = _emprestimoService.oRepositoryCliente.SelecionarTodos();
            List<Livro> oListLivro = _emprestimoService.oRepositoryLivro.SelecionarTodos();

            oEmprestimoViewModel.oListCliente = oListCliente;
            oEmprestimoViewModel.oListLivro = oListLivro;
            oEmprestimoViewModel.dataEmprestimo = DateTime.Now;
            oEmprestimoViewModel.dataEntrega = DateTime.Now.AddDays(7);

            return View(oEmprestimoViewModel);
        }
        [HttpPost]
        public IActionResult Create(EmprestimoViewModel oEmprestimoViewModel)
        {
            LivroClienteEmprestimo oLivroClienteEmprestimo = new LivroClienteEmprestimo();
            oLivroClienteEmprestimo.LceldDataEmprestimo = oEmprestimoViewModel.dataEmprestimo;
            oLivroClienteEmprestimo.LceldDataEntrega = oEmprestimoViewModel.dataEntrega;
            oLivroClienteEmprestimo.LceldLivro = Convert.ToInt32(oEmprestimoViewModel.oLivroId);
            oLivroClienteEmprestimo.LceldCliente = Convert.ToInt32(oEmprestimoViewModel.oClienteId);
            oLivroClienteEmprestimo.LceldEntregue = false;

            if (!ModelState.IsValid)
            {
                return View(oEmprestimoViewModel);
            }

            

            _emprestimoService.oRepositoryLivroClienteEmprestimo.Incluir(oLivroClienteEmprestimo);
            return RedirectToAction("Index");
        }
    }


}
