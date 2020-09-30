using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using LP4EL.Model.Dtos;
using LP4EL.Model.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LP4EL.Areas.Painel.Controllers
{
    [Area("Painel")]
    [Authorize]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}