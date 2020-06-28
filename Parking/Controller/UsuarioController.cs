using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParkingContext;
using ParkingContext.Models;
using ParkingModel;

namespace ParkingWebApi.Controller
{
    [Route("usuario/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {


        private readonly UsuarioService usuarioService;

        public UsuarioController(UsuarioService usuarioService)
        {
            this.usuarioService = usuarioService;
        }

    }
}
