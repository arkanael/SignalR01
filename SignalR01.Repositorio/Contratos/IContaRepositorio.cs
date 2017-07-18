using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignalR01.Entidades;
using Signal01.Entidades.DTO;

namespace SignalR01.Repositorio.Contratos
{
    public interface IContaRepositorio :IbaseRepositorio<Conta>
    {
        List<Conta> ListarPorData(DateTime dataIni, DateTime dateFim);

        List<SomatorioTipoConta> ObterSomatorioPorData(DateTime dataIni, DateTime dataFim);
    }
}
 