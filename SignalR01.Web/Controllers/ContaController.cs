using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SignalR01.Web.Controllers
{
    public class ContaController : Controller
    {
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
    }
}