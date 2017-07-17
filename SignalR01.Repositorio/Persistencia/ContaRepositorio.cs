using SignalR01.Entidades;
using SignalR01.Repositorio.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR01.Repositorio.Persistencia
{
    public class ContaRepositorio : BaseRepositorio<Conta>, IContaRepositorio
    {
        public List<Conta> ListarPorData(DateTime dataIni, DateTime dateFim)
        {
            return contexto.Conta
                .Where(c => c.Data >= dataIni && c.Data <= dateFim)
                .OrderBy(c => c.Data)
                .ToList();
        }
    }
}
