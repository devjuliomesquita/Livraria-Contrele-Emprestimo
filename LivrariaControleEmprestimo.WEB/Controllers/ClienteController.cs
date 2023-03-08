using LivrariaContreleEmprestimo.DATA.Models;
using LivrariaContreleEmprestimo.DATA.Services;
using Microsoft.AspNetCore.Mvc;

namespace LivrariaControleEmprestimo.WEB.Controllers
{
    public class ClienteController : Controller
    {
        private ClienteService oClienteService = new ClienteService();
        public IActionResult Index()
        {
            List<Cliente> oListClientes = oClienteService.oRepositoryCliente.SelecionarTodos();
            return View(oListClientes);
        }
        public IActionResult Create() 
        { 
            return View(); 
        }
        [HttpPost]
        public IActionResult Create(Cliente cliente)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }

            oClienteService.oRepositoryCliente.Incluir(cliente);
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            Cliente cliente = oClienteService.oRepositoryCliente.SelecionarPk(id);
            return View(cliente);
        }
        public IActionResult Edit(int id)
        {
            Cliente cliente = oClienteService.oRepositoryCliente.SelecionarPk(id);
            return View(cliente);
        }
        [HttpPost]
        public IActionResult Edit(Cliente cliente)
        {
            Cliente oCliente = oClienteService.oRepositoryCliente.Alterar(cliente);

            int id = oCliente.Id;

            return RedirectToAction("Details", new { id });
        }
        public IActionResult Delete(int id)
        {
            oClienteService.oRepositoryCliente.Excluir(id);
            return RedirectToAction("Index");
        }
    }
}
