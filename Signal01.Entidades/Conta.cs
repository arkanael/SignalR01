using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignalR01.Entidades.Tipo;

namespace SignalR01.Entidades
{
    public class Conta
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public TipoConta Tipo { get; set; }
    }
}
