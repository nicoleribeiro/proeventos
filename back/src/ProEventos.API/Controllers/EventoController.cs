using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        // criando dois eventos
        public IEnumerable<Evento> _evento = new Evento[]{
            new Evento(){
                EventoId = 1,
                Tema = "Angular e .NET 5",
                Local = "São Paulo",
                Lote = "1º lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemURL = "foto.png"
            },
            new Evento(){
                EventoId = 2,
                Tema = "Angular e .NET 5 v2",
                Local = "São Paulo Capital",
                Lote = "2º lote",
                QtdPessoas = 350,
                DataEvento = DateTime.Now.AddDays(5).ToString("dd/MM/yyyy"),
                ImagemURL = "foto1.png"
            }
        };
        // construtor vazio da controller
        public EventoController()
        {

        }

        // rota método get
        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        // rota método get com id
        [HttpGet("{id}")]
        public IEnumerable<Evento> GetByID(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }

        // rota método post
        [HttpPost]
        public string Post()
        {
            return "post";
        }

        // rota método put com id
        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"put = {id}";
        }

        // rota método delete com id
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"delete = {id}";
        }
    }
}
