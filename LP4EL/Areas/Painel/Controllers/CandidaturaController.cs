using LP4EL.Model.Dtos;
using LP4EL.Model.Interfaces;
using LP4EL.Areas.Painel.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LP4EL.Areas.Painel.Controllers
{
    [Area("Painel")]
    [Authorize]
    public class CandidaturaController : Controller
    {
        private readonly ICandidaturaBusiness _candidaturaBusiness;

        public CandidaturaController(ICandidaturaBusiness candidaturaBusiness)
        {
            this._candidaturaBusiness = candidaturaBusiness;
        }

        public IActionResult Cadastrar()
        {
            var candidatura = _candidaturaBusiness.Filtrar();

            return View(candidatura);
        }

        public IActionResult Novo()
        {
            ViewData["Title"] = "Nova Candidatura";
            return View("SalvarCandidatura", new CandidaturaDto());
        }

        public IActionResult Editar(int id)
        {
            var candidatura = _candidaturaBusiness.Selecionar(id);
            ViewData["Title"] = "Editar Candidatura";
            return View("SalvarCandidatura", candidatura);
        }

        [HttpPost]
        public IActionResult Salvar(CandidaturaDto candidaturaDto)
        {
            var resultado = _candidaturaBusiness.Salvar(candidaturaDto);
            return Json(new ResultadoViewModel
            {
                Sucesso = resultado.Sucesso,
                Id = resultado.Id,
                Url = Url.Action("Candidatar")
            });
        }

        public IActionResult Excluir(int id)
        {
            var resultado = _candidaturaBusiness.Excluir(id);
            return Json(new ResultadoViewModel
            {
                Sucesso = resultado.Sucesso,
                Url = Url.Action("Candidatar")
            });
        }
    }
}
