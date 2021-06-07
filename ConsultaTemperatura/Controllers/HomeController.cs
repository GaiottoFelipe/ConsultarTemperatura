using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Tempo.BLL.Models;
using WebApplication1.DAL.Interfaces;
using WebApplication1.DAL.Repositorios;

namespace ConsultaTemperatura.Controllers
{
    public class HomeController : Controller
    {


        

        private readonly ITemperaturaRepositorio _temperatura;

        public HomeController()
        {
            _temperatura = new TemperaturaRepositorio();
        }

        public async Task<IActionResult> Index()
        {

            string url = "https://api.openweathermap.org/data/2.5/weather?q=SAO%20PAULO&appid=c02891c1ba6b87156a106730fb724b77";
            var response = await _temperatura.PegarTemperatura(url);
            var tempoSP = JsonConvert.DeserializeObject<main>(response);
            return View(tempoSP);

        }

    }
}
