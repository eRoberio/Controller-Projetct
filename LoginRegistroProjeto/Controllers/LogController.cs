using Agenda.Models.Entidades.Contexto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegistroProjeto.Controllers
{
    public class LogController : Controller
    {

        private readonly Contexto _contexto;

        public LogController(Contexto contexto)
        {
            _contexto = contexto;
        }
        


        //GET DO LOG
        public async Task<IActionResult> Index()
        {

            return View(await _contexto.Log.ToListAsync());
        }


    }
}
