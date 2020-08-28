using DevBoost.JWT.Contract;
using DevBoost.JWT.Model;
using DevBoost.JWT.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace DevBoost.JWT.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        readonly private IUserService _userService;
       
        public AccountController(IUserService userService) {
            _userService = userService;
        }

        /// <summary>
        /// Login
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /Todo
        ///     {
        ///        "username": "username",
        ///        "password": "password
        ///     }
        ///
        /// </remarks>
        /// <param name="item"></param>
        /// <returns>A newly created TodoItem</returns>
        /// <response code="200">Returns the newly created token</response>
        /// <response code="404">If the item is null</response>             
        [HttpPost]
        [Route("login")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<dynamic>> Authenticate([FromBody]User model)
        {
            var response= await _userService.Authentication(model);

            if (response.HasFails) {

                return UnprocessableEntity(response.Fails);
            }

            return Ok(response.Data);
        }

        [HttpGet]
        [AllowAnonymous]
        public string Anonymous() => "Anônimo";

      

    }
}
