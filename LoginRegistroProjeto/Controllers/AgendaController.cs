using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agenda.Models.Entidades;
using Agenda.Models.Entidades.Contexto;
using LoginRegistroProjeto.Areas.Identity.Data;
using LoginRegistroProjeto.Models;
using LoginRegistroProjeto.Models.Entidades;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Agenda.Controllers
{

    public class AgendaController : Controller
    {

     

        public IEnumerable<Log> Logs { get; set; }

        private readonly Contexto _contexto;

        public AgendaController(Contexto contexto)
        {
            _contexto = contexto;

        }



        //  !Listar
        public IActionResult Index( string sortOrder ,string searchString)
        {


            ViewBag.NomeParam = String.IsNullOrEmpty(searchString) ? "Nome_desc" : "";
            ViewBag.DataParam = searchString == "Date" ? "Date_desc" : "Date";

            var eventos = from s in _contexto.Agendamento select s;




            if (!String.IsNullOrEmpty(searchString))
            {
                eventos = eventos.Where(s => s.nome.ToUpper().Contains(searchString.ToUpper())
                                       || s.nome.ToUpper().Contains(searchString.ToUpper()));
            }
            switch (sortOrder)
            {
                case "Nome_desc":
                    eventos = eventos.OrderByDescending(s => s.nome);
                    break;
                case "Date":
                    eventos = eventos.OrderBy(s => s.dataCadastroEvento);
                    break;
                case "Date_desc":
                    eventos = eventos.OrderByDescending(s => s.dataCadastroEvento);
                    break;
                default:
                    eventos = eventos.OrderBy(s => s.nome);
                    break;
            }

            return View(eventos.ToList());
        }



















        //Método de Criar
        [HttpGet]
        public IActionResult Criar()
        {
            CarregarListAgenda();
            var agendas = new Eventos();

            _contexto.Log.Add(
                new Log
                {
                    EmailUsuario = User.Identity.Name,
                    DetalhesLog = "Parece que vai realizar o cadastro de um novo Evento"
                }

                );
            _contexto.SaveChanges();

            
            return View(agendas);

        }



        [HttpPost]
        public IActionResult Criar(Eventos agendas)
        {
            if (ModelState.IsValid)
            {
                _contexto.Agendamento.Add(agendas);
                _contexto.SaveChanges();

                _contexto.Log.Add(
               new Log
               {
                   EmailUsuario = User.Identity.Name,
                   DetalhesLog = string.Concat("Cadastrou um novo Evento: ",
                   agendas.nome, "Data: ",
                   DateTime.Now.ToLongDateString())
               }

               );

                ViewBag.salvou = User.Identity.Name;
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



            _contexto.Log.Add(
               new Log
               {
                   EmailUsuario = User.Identity.Name,
                   DetalhesLog = string.Concat("Parece que vai realizar uma edição em:",

                        agendas.Id, " - ", agendas.nome
                   )
               }
               );
            _contexto.SaveChanges();


            return View(agendas);

        }
        [HttpPost]
        public IActionResult Edit(Eventos agendas)
        {
            if (ModelState.IsValid)
            {
                _contexto.Agendamento.Update(agendas);
                _contexto.SaveChanges();


                _contexto.Log.Add(
             new Log
             {
                 EmailUsuario = User.Identity.Name,
                 DetalhesLog = string.Concat("Atualizou o Evento: ",
                 agendas.nome, "Data de Atialização: ",
                 DateTime.Now.ToLongDateString())


             }

             );
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
        public IActionResult Delete(Eventos _agenda)
        {

            var agendas = _contexto.Agendamento.Find(_agenda.Id);
            if (agendas != null)
            {
                _contexto.Agendamento.Remove(agendas);
                _contexto.SaveChanges();

                _contexto.Log.Add(
             new Log
             {
                 EmailUsuario = User.Identity.Name,
                 DetalhesLog = string.Concat("Apagou o Evento",
                 agendas.nome, "Data de Exclução: ",
                 DateTime.Now.ToLongDateString())


             }

             );
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
            _contexto.Log.Add(
            new Log
            {
                EmailUsuario = User.Identity.Name,
                DetalhesLog = string.Concat("Parece que vai ver os Detalhes uma edição em:",

                     agendas.Id, " - ", agendas.nome
                )
            }
            );
            _contexto.SaveChanges();



            return View(agendas);

        }

        //Tenho que fazer isso em 'Sexo' de Usuários !

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




        [AllowAnonymous]
        [HttpGet("api/ListarProdutos")]
        public async Task<JsonResult> ListarProdutos()
        {
            return Json(await _contexto.Agendamento.ToListAsync());
        }



        [AllowAnonymous]
        [HttpPost("api/AdicionarProd")]
        public async void AdicionarProd(string id, string nome, string qtd)
        {

            _contexto.Agendamento.Add(new Eventos
            {
                Id = Convert.ToInt32(id),
                nome = nome,
                tipo = qtd
            });


            _contexto.SaveChanges();

        }






    }
}
