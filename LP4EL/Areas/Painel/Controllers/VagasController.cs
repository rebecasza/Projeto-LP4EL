using LP4EL.Model.Dtos;
using LP4EL.Model.Interfaces;
using LP4EL.Areas.Painel.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LP4EL.Areas.Painel.Controllers
{
    [Area("Painel")]
    [Authorize]
    public class VagasController : Controller
    {
        private readonly IVagasBusiness _vagasBusiness;

        public VagasController(IVagasBusiness vagasBusiness)
        {
            this._vagasBusiness = vagasBusiness;
        }

        public IActionResult Consultar()
        {
            var vagas = _vagasBusiness.Filtrar();

            return View(vagas);
        }

        public IActionResult Novo()
        {
            ViewData["Title"] = "Nova Vaga";
            return View("Salvar", new VagasDto());
        }

        public IActionResult Editar(int id)
        {
            var vaga = _vagasBusiness.Selecionar(id);
            ViewData["Title"] = "Editar Vaga";
            return View("Salvar", vaga);
        }

        [HttpPost]
        public IActionResult Salvar(VagasDto vagasDto)
        {
            var resultado = _vagasBusiness.Salvar(vagasDto);
            return Json(new ResultadoViewModel
            {
                Sucesso = resultado.Sucesso,
                Id = resultado.Id,
                Url = Url.Action("Consultar")
            });
        }

        public IActionResult Excluir(int id)
        {
            var resultado = _vagasBusiness.Excluir(id);
            return Json(new ResultadoViewModel
            {
                Sucesso = resultado.Sucesso,
                Url = Url.Action("Consultar")
            });
        }
    }
}
