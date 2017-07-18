using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SignalR01.Repositorio.Contratos;
using SignalR01.Web.Models;
using SignalR01.Entidades;
using SignalR01.Entidades.Tipo;
using SignalR01.Repositorio.Persistencia;

namespace SignalR01.Web.Controllers
{
    public class ContaController : Controller
    {
        //Atributo para receber injeção de de dependência
        private readonly IContaRepositorio contaRepositorio;

        //Simple injector inicialize o atributo da interface
        public ContaController(IContaRepositorio contaRepositorio)
        {
            this.contaRepositorio = contaRepositorio;
        }
       
        // GET: Conta/Cadastro
        public ActionResult Cadastro()
        {
            return View();
        }

        // GET: Conta/Consulta
        public ActionResult Consulta()
        {
            return View();
        }

        //Método para a resquisição javascript de cadastro..
        public JsonResult CadastrarConta(ContaViewModelCadastro model)
        {
            try
            {
                Conta c = new Conta()
                {
                    Nome = model.Nome,
                    Valor = model.Valor,
                    Data = model.Data,
                    Tipo = (TipoConta) model.Tipo

                };

                contaRepositorio.Inserir(c);

                return Json($"Conta {c.Nome} cadastrada com sucesso.");
            }
            catch (Exception e)
            {
                return Json(e.Message);
            }
        }

        //Método para requisição javascript de pesquisa
        public JsonResult PesquisarContas(ContaViewModelFiltroPesquisa model)
        {
            try
            {
                //Lista com os resultados que serão enviados para a página
                var lista = new List<ContaViewModelResultadoPesquisa>();

                foreach (Conta c in contaRepositorio.ListarPorData(model.DataInicio, model.DataTermino))
                {
                    var item = new ContaViewModelResultadoPesquisa();
                    item.Id = c.Id;
                    item.Nome = c.Nome;
                    item.Valor = c.Valor;
                    item.Data = c.Data.ToString("ddd dd/MM/yyyy");
                    item.Tipo = c.Tipo.ToString();

                    lista.Add(item);
                }

                return Json(lista);
            }
            catch (Exception e)
            {
                return Json(e.Message);
            }
        }

       public JsonResult ObterResumoContas(ContaViewModelFiltroPesquisa model)
        {
            try
            {
                var lista = new List<ContaViewModelSomatorioTipo>();

                //Varrer os somotarios das contas
                foreach (var c in contaRepositorio.ObterSomatorioPorData(model.DataInicio, model.DataTermino))
                {
                    var item = new ContaViewModelSomatorioTipo();

                    item.TipoConta = c.Tipo.ToString();
                    item.Somatorio = c.Somatorio;

                    lista.Add(item);
                }

                return Json(lista);
            }
            catch (Exception e)
            {
                return Json(e.Message);
            }
        }
    }
}