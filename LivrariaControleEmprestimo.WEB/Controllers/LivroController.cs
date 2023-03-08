using LivrariaContreleEmprestimo.DATA.Models;
using LivrariaContreleEmprestimo.DATA.Services;
using Microsoft.AspNetCore.Mvc;

namespace LivrariaControleEmprestimo.WEB.Controllers
{
    public class LivroController : Controller
    {
        private LivroService oLivroService = new LivroService();
        public IActionResult Index()
        {
            List<Livro> oListaLivros = oLivroService.oRepositoryLivro.SelecionarTodos();
            return View(oListaLivros);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Livro livro)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            oLivroService.oRepositoryLivro.Incluir(livro);
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            Livro livro = oLivroService.oRepositoryLivro.SelecionarPk(id);
            return View(livro);
        }
        public IActionResult Edit(int id)
        {
            Livro livro = oLivroService.oRepositoryLivro.SelecionarPk(id);
            return View(livro);
        }
        [HttpPost]
        public IActionResult Edit(Livro livro)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }

            Livro oLivro = oLivroService.oRepositoryLivro.Alterar(livro);
            int id = oLivro.Id;

            return RedirectToAction("Details", new { id });
        }
        public IActionResult Delete(int id)
        {
            oLivroService.oRepositoryLivro.Excluir(id);
            return RedirectToAction("Index");
        }
    }
}
