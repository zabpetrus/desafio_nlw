﻿using Journey.Application.UseCases.Trips.Register;
using Journey.Communication.Requests;
using Journey.Exception.ExceptionsBase;
using Microsoft.AspNetCore.Mvc;


//ctrl + r + g => limpar dependencias não usadas

namespace Journey.Api.Controllers
{
    /// <summary>
    /// Trips Controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class TripsController : ControllerBase
    {
        /// <summary>
        /// Register
        /// </summary>
        /// <returns>An IActionResult.</returns>
        [HttpPost]
        public IActionResult Register([FromBody] RequestRegisterTripJson request)
        {
            try
            {
                var useCase = new RegisterTripUseCase();
                useCase.Execute(request);
                return Created();
            }
            catch (JourneyException ex)
            {
               return BadRequest(ex.Message);   
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro desconhecido");
            }
        }
    }
}
