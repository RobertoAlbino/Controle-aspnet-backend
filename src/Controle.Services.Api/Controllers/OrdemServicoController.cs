using Microsoft.AspNetCore.Mvc;

namespace Controle.Services.Api.Controllers
{
    public class OrdemServicoController : Controller
    {
        [HttpPost]
        [Route("api/ordemservico/integrar")]
        public JsonResult Integrar()
        {
            return Json("Ordem de serviço integrada com sucesso.");
        }
    }
}