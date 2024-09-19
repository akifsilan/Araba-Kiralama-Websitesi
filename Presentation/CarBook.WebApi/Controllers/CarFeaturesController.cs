using CarBook.Application.Features.Mediator.Commands.CarFeatureCommands;
using CarBook.Application.Features.Mediator.Queries.BlogQueries;
using CarBook.Application.Features.Mediator.Queries.CarFeatureQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarFeaturesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CarFeaturesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> CarFeatureListByCar(int id)
        {
            var value = await _mediator.Send(new GetCarFeatureByCarIdQuery(id));
            return Ok(value);
        }

        [HttpGet("GetFeatureChangeAvailableToFalse")]
        public async Task<IActionResult> GetFeatureChangeAvailableToFalse(int id)
        {
            _mediator.Send(new UpdateCarFeatureAvailableChangeToFalseCommand(id));
            return Ok("Güncelleme yapıldı!");
        }

        [HttpGet("GetFeatureChangeAvailableToTrue")]
        public async Task<IActionResult> GetFeatureChangeAvailableToTrue(int id)
        {
            _mediator.Send(new UpdateCarFeatureAvailableChangeToTrueCommand(id));
            return Ok("Güncelleme yapıldı");
        }
        [HttpPost]
        public async Task<IActionResult> CreateCarFeatureByCarID(CreateCarFeatureByCarCommand createCarFeatureByCarCommand)
        {
            _mediator.Send(createCarFeatureByCarCommand);
            return Ok("Ekleme yapıldı");
        }
    }
}
