
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newsboard.Services.AuthService.API.Repositories;

namespace Newsboard.Services.AuthService.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository auth;
        public AuthController(IAuthRepository auth) : base()
        {
            this.auth = auth;

        }

    }
}