using SignalR01.Entidades.Tipo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signal01.Entidades.DTO
{
    public class SomatorioTipoConta
    {
        public TipoConta Tipo { get; set; }
        public decimal Somatorio { get; set; }

    }
}
