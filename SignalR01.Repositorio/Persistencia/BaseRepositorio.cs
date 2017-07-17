using SignalR01.Repositorio.Contexto;
using SignalR01.Repositorio.Contratos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR01.Repositorio.Persistencia
{
    public abstract class BaseRepositorio<TEntity> : IbaseRepositorio<TEntity> where TEntity : class
    {
        protected DataContext contexto;

        public BaseRepositorio()
        {
            contexto = new DataContext();
        }
        public void Atualizar(TEntity obj)
        {
            contexto.Entry(obj).State = EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }

        public void Excluir(TEntity obj)
        {
            contexto.Entry(obj).State = EntityState.Deleted;
            contexto.SaveChanges();
        }

        public void Inserir(TEntity obj)
        {
            contexto.Entry(obj).State = EntityState.Added;
            contexto.SaveChanges();
        }

        public List<TEntity> ListarTodos(int id)
        {
            return contexto.Set<TEntity>().ToList();
        }

        public TEntity ObterPorId(int id)
        {
            return contexto.Set<TEntity>().Find(id);
        }
    }
}
