using Agenda.Models.Entidades.Contexto;
using LoginRegistroProjeto.Models.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginRegistroProjeto.Controllers
{
    public class MinhaAgendaController : Controller
    {
        private readonly Contexto _contexto;

        public MinhaAgendaController(Contexto contexto)
        {
            _contexto = contexto;
        }



        //GET DE MinhaAgendaController
        public IActionResult Index()
        {


            CarregarListAgenda();
            var list = _contexto.MinhaAgenda.ToList();
            return View(list);
        }






        [HttpGet]
        public IActionResult CriarEventoPessoal()
        {

            CarregarListAgenda();

            var agendaPessoal = new MinhaAgenda();

            _contexto.SaveChanges();

            return View(agendaPessoal);
        }


        [HttpPost]

        public IActionResult CriarEventoPessoal(MinhaAgenda agendaPessoal)
        {
            if (ModelState.IsValid)
            {
                _contexto.MinhaAgenda.Add(agendaPessoal);
                _contexto.SaveChanges();

                _contexto.Log.Add(
               new Log
               {
                   EmailUsuario = User.Identity.Name,
                   DetalhesLog = string.Concat("Cadastrou um novo Evento: ",
                   agendaPessoal.Nome, "Data: ",
                   DateTime.Now.ToLongDateString())
               }

               );
                _contexto.SaveChanges();


                return RedirectToAction("Index");
            }
            return View(agendaPessoal);
        }



        //Método de Detalhes
        [HttpGet]
        public IActionResult Detalhes(int id)
        {
            CarregarListAgenda();
            var agendaPessoal = _contexto.MinhaAgenda.Find(id);
            _contexto.Log.Add(
            new Log
            {
                EmailUsuario = User.Identity.Name,
                DetalhesLog = string.Concat("Entrou em Detalhes:",

                     agendaPessoal.Id, " - ", agendaPessoal.Nome
                )
            }
            );
            _contexto.SaveChanges();



            return View(agendaPessoal);

        }








        public void CarregarListAgenda()
        {
            var ItensAgenda = new List<SelectListItem>
            {
                new SelectListItem{ Value = "1", Text ="Exclusivo" },
                new SelectListItem{ Value = "2", Text ="Compartilhado" }
            };

            var ItensStatus = new List<SelectListItem>
            {
                new SelectListItem{ Value = "1", Text ="Aberto" },
                new SelectListItem{ Value = "2", Text ="Fechado" },


            };

            ViewBag.tipo = ItensAgenda;
            ViewBag.status = ItensStatus;
        }



    }
}
