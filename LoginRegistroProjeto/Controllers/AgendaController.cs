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
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;


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
        public IActionResult Index(string sortOrder, string searchString)
        {
            var IdUserGlobal = User?.FindFirstValue(ClaimTypes.NameIdentifier);

            ViewBag.NomeParam = String.IsNullOrEmpty(searchString) ? "Nome_desc" : "";
            ViewBag.DataParam = searchString == "Date" ? "Date_desc" : "Date";


            var eventos = _contexto.Eventos.Include("UserCreate").Include("EventoUsuarios");




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
                    eventos = eventos.OrderBy(s => s.DataEvento);
                    break;
                case "Date_desc":
                    eventos = eventos.OrderByDescending(s => s.DataEvento);
                    break;
                default:
                    eventos = eventos.OrderBy(s => s.nome);
                    break;
            }

         

            var model = eventos.Select(x => new EventosModel
            {

                Id = x.Id,
                nome = x.nome,
                Email = x.UserCreate.Email,
                descricao = x.descricao,
                local = x.local,
                tipo = x.tipo,
                status = x.status,
                DataEvento = x.DataEvento,
                PermitirInscricao = string.IsNullOrEmpty(IdUserGlobal)
                ? false :
                !_contexto.EventoUsuarios.Any
                (y => y.Usuario.Id == IdUserGlobal && y.EventoId == x.Id),
                QtdInscritos = x.EventoUsuarios.Count

            }).ToList();


            return View(model);



        }


        //Método de Criar
        [HttpGet]
        public IActionResult Criar()
        {
            CarregarListAgenda();
            var agendas = new Eventos();


            //_contexto.EventoUsuarios.Find();

            _contexto.Log.Add(
                new Log
                {
                    //EmailUsuario = User.FindFirstValue(ClaimTypes.NameIdentifier), ID DO USUÁRIO QUE ESTÁ CONECTADO

                    EmailUsuario = User?.FindFirstValue(ClaimTypes.NameIdentifier),

                    DetalhesLog = "Parece que vai realizar o cadastro de um novo Evento"
                }

                );

            _contexto.SaveChanges();


            return View(agendas);

        }



       

            [HttpGet]
        public IActionResult Participar(int id)
        {
            var evento = _contexto.Eventos.FirstOrDefault(x => x.Id == id);
            var user = _contexto.AplicativoUsuarios
             .FirstOrDefault(x => x.Id == User
             .FindFirstValue(ClaimTypes.NameIdentifier));

            var eventoUsuario =
                new EventoUsuario
                {
                    Evento = evento,
                    Usuario = user
                };

            _contexto.EventoUsuarios.Add(eventoUsuario);

            _contexto.SaveChanges();

            return RedirectToAction("Index");

        }



        [HttpPost]
        public IActionResult Criar(Eventos eventos)
        {
            var user = _contexto.AplicativoUsuarios
                .FirstOrDefault(x => x.Id == User
                .FindFirstValue(ClaimTypes.NameIdentifier));




            eventos.UserCreate = user;


            if (ModelState.IsValid)
            {
                _contexto.Eventos.Add(eventos);
                _contexto.SaveChanges();

                _contexto.Log.Add(
               new Log
               {
                   EmailUsuario = User.Identity.Name,
                   DetalhesLog = string.Concat("Cadastrou um novo Evento: ",
                   eventos.nome, "Data: ",
                   DateTime.Now.ToLongDateString())
               }

               );



                _contexto.SaveChanges();


                return RedirectToAction("Index");
            }


            return View(eventos);
        }


        //Método de Editar
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var eventos = _contexto.Eventos.Find(id);
            CarregarListAgenda();



            _contexto.Log.Add(
               new Log
               {
                   EmailUsuario = User.Identity.Name,
                   DetalhesLog = string.Concat("Parece que vai realizar uma edição em:",

                        eventos.Id, " - ", eventos.nome
                   )
               }
               );
            _contexto.SaveChanges();


            return View(eventos);

        }
        [HttpPost]
        public IActionResult Edit(Eventos eventos)
        {
            if (ModelState.IsValid)
            {
                _contexto.Eventos.Update(eventos);
                _contexto.SaveChanges();


                _contexto.Log.Add(
             new Log
             {
                 EmailUsuario = User.Identity.Name,
                 DetalhesLog = string.Concat("Atualizou o Evento: ",
                 eventos.nome, "Data de Atialização: ",
                 DateTime.Now.ToLongDateString())


             }

             );
                _contexto.SaveChanges();



                return RedirectToAction("Index");
            }
            else
            {
                CarregarListAgenda();

                return View(eventos);
            }
        }


        //Método de Delete
        [HttpGet]
        public IActionResult Delete(int id)
        {
            CarregarListAgenda();
            var eventos = _contexto.Eventos.Find(id);

            return View(eventos);

        }




        [HttpPost]
        public IActionResult Delete(Eventos _eventos)
        {

            var eventos = _contexto.Eventos.Find(_eventos.Id);
            if (eventos != null)
            {
                _contexto.Eventos.Remove(eventos);
                _contexto.SaveChanges();

                _contexto.Log.Add(
             new Log
             {
                 EmailUsuario = User.Identity.Name,
                 DetalhesLog = string.Concat("Apagou o Evento",
                 eventos.nome, "Data de Exclução: ",
                 DateTime.Now.ToLongDateString())


             }

             );
                _contexto.SaveChanges();



                return RedirectToAction("Index");


            }


            return View(eventos);

        }




        //Método de Detalhes
        [HttpGet]
        public IActionResult Detalhes(int id)
        {
            CarregarListAgenda();
            var eventos = _contexto.Eventos.Find(id);
            _contexto.Log.Add(
            new Log
            {
                EmailUsuario = User.Identity.Name,
                DetalhesLog = string.Concat("Parece que vai ver os Detalhes uma edição em:",

                     eventos.Id, " - ", eventos.nome
                )
            }
            );
            _contexto.SaveChanges();



            return View(eventos);

        }

        //Tenho que fazer isso em 'Sexo' de Usuários !

        public void CarregarListAgenda()
        {
            var ItensEventos = new List<SelectListItem>
            {
                new SelectListItem{ Value = "Exclusivo", Text ="Exclusivo" },
                new SelectListItem{ Value = "Compartilhado", Text ="Compartilhado" }
            };

            var ItensStatus = new List<SelectListItem>
            {
                new SelectListItem{ Value = "Aberto", Text ="Aberto" },
                new SelectListItem{ Value = "Fechado", Text ="Fechado" },


            };




            ViewBag.tipo = ItensEventos;
            ViewBag.status = ItensStatus;
        }






    }
}
