using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalR01.Web.Models
{
   
    //modelo de dados da requisição de cadastro.. 
    public class ContaViewModelCadastro
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public int Tipo { get; set; }
    }

    //modelo de dados da requisição de pesquisa.. 
    public class ContaViewModelFiltroPesquisa
    {
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
    }

    //modelo de dados da requisição de pesquisa..
    public class ContaViewModelResultadoPesquisa
    {
        public int Id{ get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public string Data { get; set; }
        public string Tipo { get; set; }
    }
}