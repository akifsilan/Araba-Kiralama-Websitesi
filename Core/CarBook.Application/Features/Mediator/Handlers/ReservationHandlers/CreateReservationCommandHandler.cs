using CarBook.Application.Features.Mediator.Commands.ReservationCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.ReservationHandlers
{
    public class CreateReservationCommandHandler : IRequestHandler<CreateReservationCommand>
    {
        private readonly IRepository<Reservation> _repository;

        public CreateReservationCommandHandler(IRepository<Reservation> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateReservationCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Reservation
            {
                Age = request.Age,
                Name = request.Name,
                Surname = request.Surname,
                Phone = request.Phone,
                Description = request.Description,
                DriverLicenseYear = request.DriverLicenseYear,
                Email = request.Email,
                CarID = request.CarID,
                DropOffLocationID = request.DropOffLocationID,
                PickUpLocationID = request.PickUpLocationID,  
                Status = "Rezervasyon Alındı"
            });
        }
    }
}
