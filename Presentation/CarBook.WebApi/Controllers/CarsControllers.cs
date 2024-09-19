﻿using CarBook.Application.Features.CQRS.Commands.CarCommands;
using CarBook.Application.Features.CQRS.Handlers.CarHandlers;
using CarBook.Application.Features.CQRS.Queries.CarQueries;
using CarBook.Application.Features.CQRS.Results.CarResults;
using CarBook.Application.Features.Mediator.Queries.StatisticsQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace CarBook.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CarsControllers : ControllerBase
	{
		private readonly CreateCarCommandHandler _createCarCommandHandler;
		private readonly UpdateCarCommandHandler _updateCarCommandHandler;
		private readonly RemoveCarCommandHandler _removeCarCommandHandler;
		private readonly GetCarByIdQueryHandler _getCarByIdQueryHandler;
		private readonly GetCarQueryHandler _getCarQueryHandler;
		private readonly GetCarWithBrandQueryHandler _getCarWithBrandQueryHandler;
		private readonly GetLast5CarsWithBrandQueryHandler _getLast5CarsWithBrandQueryHandler;


		public CarsControllers(GetCarWithBrandQueryHandler getCarWithBrandQueryHandler,
			CreateCarCommandHandler createCarCommandHandler,
			UpdateCarCommandHandler updateCarCommandHandler,
			RemoveCarCommandHandler removeCarCommandHandler,
			GetCarByIdQueryHandler getCarByIdQueryHandler,
			GetCarQueryHandler getCarQueryHandler,
			GetLast5CarsWithBrandQueryHandler getLast5CarsWithBrandQueryHandler)
		{
			_createCarCommandHandler = createCarCommandHandler;
			_updateCarCommandHandler = updateCarCommandHandler;
			_removeCarCommandHandler = removeCarCommandHandler;
			_getCarByIdQueryHandler = getCarByIdQueryHandler;
			_getCarQueryHandler = getCarQueryHandler;
			_getCarWithBrandQueryHandler = getCarWithBrandQueryHandler;
			_getLast5CarsWithBrandQueryHandler = getLast5CarsWithBrandQueryHandler;
		}

		[HttpGet]
		public async Task<IActionResult> CarList()
		{
			var values = await _getCarQueryHandler.Handle();
			return Ok(values);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetCar(int id)
		{
			var values = await _getCarByIdQueryHandler.Handle(new GetCarByIdQuery(id));
			return Ok(values);
		}

		[HttpPost]
		public async Task<IActionResult> CreateCar(CreateCarCommand command)
		{
			await _createCarCommandHandler.Handle(command);
			return Ok("Araba oluşturuldu");
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> RemoveCar(int id)
		{
			await _removeCarCommandHandler.Handle(new RemoveCarCommand(id));
			return Ok("Araba kaldırıldı");
		}

		[HttpPut]
		public async Task<IActionResult> UpdateCar(UpdateCarCommand command)
		{
			await _updateCarCommandHandler.Handle(command);
			return Ok("Araba güncellendi");
		}

		[HttpGet("GetCarWithBrand")]
		public IActionResult GetCarWithBrand()
		{
			var values = _getCarWithBrandQueryHandler.Handle();
			return Ok(values);

		}

		[HttpGet("GetLast5CarsWithBrand")]
		public IActionResult GetLast5CarsWithBrand()
		{
			var values = _getLast5CarsWithBrandQueryHandler.Handle();
			return Ok(values);
		}
	}
}