using LivrariaContreleEmprestimo.DATA.Data;
using LivrariaContreleEmprestimo.DATA.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaContreleEmprestimo.DATA.Repositories
{
    public class RepositoryBase<T> : IDisposable, IRepositoryModel<T> where T : class
    {
        protected ControleEmprestimoLivroContext _contexto;
        public bool _SaveChanges = true;
        public RepositoryBase(bool saveChanges = true)
        {
            _SaveChanges= saveChanges;
            _contexto = new ControleEmprestimoLivroContext();

        }

        public T Alterar(T objeto)
        {
            _contexto.Entry(objeto).State = EntityState.Modified;
            if (_SaveChanges)
            {
                _contexto.SaveChanges();
            }

            return objeto;
        }

        public void Dispose()
        {
            _contexto.Dispose();
        }

        public void Excluir(T objeto)
        {
            _contexto.Set<T>().Remove(objeto);
            if (_SaveChanges)
            {
                _contexto.SaveChanges();
            }
        }

        public void Excluir(params object[] variavel)
        {
            var obj = SelecionarPk(variavel);
            Excluir(obj);
        }

        public T Incluir(T objeto)
        {
            _contexto.Set<T>().Add(objeto);
            if (_SaveChanges)
            {
                _contexto.SaveChanges();
            }
            return objeto;
        }

        public void SaveChanges()
        {
            _contexto.SaveChanges();
        }

        public T SelecionarPk(params object[] variavel)
        {
            return _contexto.Set<T>().Find(variavel);
        }

        public List<T> SelecionarTodos()
        {
            return _contexto.Set<T>().ToList();
        }
    }
}
