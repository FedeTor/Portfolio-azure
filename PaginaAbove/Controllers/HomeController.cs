using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PaginaAbove.Models;
using PaginaAbove.Servicios;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PaginaAbove.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEnvioMail _enviomail;
        public HomeController(IEnvioMail enviomail)
        {
            _enviomail = enviomail;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public IActionResult EnviarDatosContacto(EnvioDatos enviodatos)
        {
            return RedirectToAction("EnviarDatosContacto");
        }

        public IActionResult EnviarDatosContacto()
        {
            return View();
        }


        [HttpPost("EnvioMail")]
        public async Task<IActionResult> Send([FromForm] RequestEnvioMail request)
        {
            var verdadero = true;       
            try
            {
                var envio = new EnvioMail()
                {
                    Body = request.mensaje,
                    Subject = request.Email,
                    ToEmail = "fedeetorancio@gmail.com"
                };
                await _enviomail.SendEmailAsync(envio);
                TempData["ok"]  = verdadero;
                return RedirectToAction("Index");

            }
            catch (Exception ex)
            {
                verdadero = false;
                TempData["ok"] = verdadero;
                throw ex;
            }

        }

        public async Task<IActionResult> EnvioMailCorrecto()
        {
            return View();
        }
    }


}
