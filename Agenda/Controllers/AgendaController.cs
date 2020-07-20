using System.Collections.Generic;
using System.Linq;
using Agenda.Models.Entidades;
using Agenda.Models.Entidades.Contexto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Agenda.Controllers
{
    public class AgendaController : Controller
    {
      

        private readonly Contexto _contexto;

        public AgendaController(Contexto contexto)
        {
            _contexto = contexto;


        }
        public IActionResult Index()
        {
            CarregarListAgenda();
            var list = _contexto.Agendamento.ToList();
            return View(list);
        }



        //Método de Criar
        [HttpGet]
        public IActionResult Criar()
        {
            CarregarListAgenda();
            var agendas = new Agendas();

            return View(agendas);

        }
        [HttpPost]
        public IActionResult Criar(Agendas agendas)
        {
            if (ModelState.IsValid)
            {
                _contexto.Agendamento.Add(agendas);
                _contexto.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(agendas);
        }








        //Método de Editar
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var agendas = _contexto.Agendamento.Find(id);
            CarregarListAgenda();

            return View(agendas);

        }
        [HttpPost]
        public IActionResult Edit(Agendas agendas)
        {
            if (ModelState.IsValid)
            {
                _contexto.Agendamento.Update(agendas);
                _contexto.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                CarregarListAgenda();
                
                return View(agendas);
            }
        }


        //Método de Delete
        [HttpGet]
        public IActionResult Delete(int id)
        {
            CarregarListAgenda();
            var agendas = _contexto.Agendamento.Find(id);
           
            return View(agendas);

        }



        [HttpPost]
        public IActionResult Delete(Agendas _agenda)
        {

            var agendas = _contexto.Agendamento.Find(_agenda.Id);
            if (agendas != null)
            {
                _contexto.Agendamento.Remove(agendas);
                _contexto.SaveChanges();
                return RedirectToAction("Index");


            }
            return View(agendas);

        }




        //Método de Detalhes
        [HttpGet]
        public IActionResult Detalhes(int id)
        {
            CarregarListAgenda();
            var agendas = _contexto.Agendamento.Find(id);

            return View(agendas);

        }


        public void CarregarListAgenda()
        {
            var ItensAgenda = new List<SelectListItem>
            {
                new SelectListItem{ Value = "1", Text ="Exclusivo" },
                new SelectListItem{ Value = "2", Text ="Compartilhado" }
            };

            ViewBag.tipo = ItensAgenda;
        }


    }
}
