using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MonProjet.Repository.Voiture;
using ProjetM2i062022.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetM2i062022.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IVoitureRepository _voitureRepository;
        public HomeController(ILogger<HomeController> logger, IVoitureRepository voitureRepository)
        {
            _logger = logger;
            _voitureRepository = voitureRepository;
        }

        public IActionResult Index()
        {
            var allVoitures = _voitureRepository.GetAllVoitures();
            _voitureRepository.AddVoiture();
            var allVoituresBis = _voitureRepository.GetAllVoitures();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
