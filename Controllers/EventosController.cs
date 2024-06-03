using Microsoft.AspNetCore.Mvc;
using MvcEventosExamen2.Models;
using MvcEventosExamen2.Services;

namespace MvcEventosExamen2.Controllers
{
    public class EventosController : Controller
    {

        private ServiceApiEventos service;

        public EventosController(ServiceApiEventos service)
        {
            this.service = service;
        }

        public async Task<IActionResult> Index()
        {
            List<Evento> eventos =
                await this.service.GetEventosAsync();
            return View(eventos);
        }

        public async Task< IActionResult> EventosCategorias()
        {
            var categorias = await this.service.GetCategoriasAsync();
            ViewData["categorias"] = categorias;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> EventosCategorias(int id)
        {
            var categorias = await this.service.GetCategoriasAsync();
            ViewData["categorias"] = categorias;
            List<Evento> evento =
                await this.service
                .GetEventosCategoriasAsync(id);
            return View(evento);
        }
    }
}
