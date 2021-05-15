using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DotnetCoreLearning.Bll.Interface;

namespace DotnetCoreLearning.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        private readonly IUserService _userService;

        public ApiController(IUserService userService) {
            _userService = userService;
        }

        [HttpGet]
        public object GetName() {
            var result = _userService.GetUserName();
            return result;
        }
    }
}