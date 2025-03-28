
using Microsoft.AspNetCore.Mvc;

namespace CnpjConsulta.Controllers
{
    public class CnpjController : Controller
    {
        private readonly CnpjService _cnpjService;

        public CnpjController(CnpjService cnpjService)
        {
            _cnpjService = cnpjService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(string cnpj)
        {
            var cnpjData = await _cnpjService.GetCnpjDataAsync(cnpj);
            return View(cnpjData);
        }
    }
}
