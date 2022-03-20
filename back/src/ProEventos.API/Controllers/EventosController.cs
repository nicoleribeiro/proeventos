using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        // construtor vazio da controller
        private readonly DataContext context;
        public EventosController(DataContext context)
        {
            this.context = context;

        }

        // rota método get
        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return context.Eventos;
        }

        // rota método get com id
        [HttpGet("{id}")]
        public Evento GetByID(int id)
        {
            return context.Eventos.FirstOrDefault(
                evento => evento.EventoId == id
            );
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
