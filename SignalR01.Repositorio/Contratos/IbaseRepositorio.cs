using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR01.Repositorio.Contratos
{
    public interface IbaseRepositorio<TEntity> where TEntity : class
    {
        void Inserir(TEntity obj);

        void Atualizar(TEntity obj);

        void Excluir(TEntity obj);

        List<TEntity> ListarTodos(int id);

        TEntity ObterPorId(int id);

        void Dispose();
    }
}
