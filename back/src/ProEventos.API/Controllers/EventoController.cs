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
        public IEnumerable<Evento> _evento = new Evento[]{
            new Evento(){
                eventoId = 1,
                tema = "Angular e .NET 5",
                local = "São Paulo",
                lote = "1º lote",
                qtdPessoas = 250,
                dataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                imagemURL = "foto.png"
            },
            new Evento(){
                eventoId = 2,
                tema = "Angular e .NET 5 v2",
                local = "São Paulo Capital",
                lote = "2º lote",
                qtdPessoas = 350,
                dataEvento = DateTime.Now.AddDays(5).ToString("dd/MM/yyyy"),
                imagemURL = "foto1.png"
            }
        };
        public EventoController()
        {

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetByID(int id)
        {
            return _evento.Where(evento => evento.eventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"put = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"delete = {id}";
        }
    }
}
