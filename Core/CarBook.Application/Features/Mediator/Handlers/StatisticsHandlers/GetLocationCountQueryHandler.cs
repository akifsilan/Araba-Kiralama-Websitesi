﻿using CarBook.Application.Features.Mediator.Queries.StatisticsQueries;
using CarBook.Application.Features.Mediator.Results.StatisticsResults;
using CarBook.Application.Interfaces.StatisticsInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationBook.Application.Features.Mediator.Handlers.StatisticsHandlers
{
    public class GetLocationCountQueryHandler: IRequestHandler<GetLocationCountQuery, GetLocationCountQueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public GetLocationCountQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetLocationCountQueryResult> Handle(GetLocationCountQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetLocationCount();
            return new GetLocationCountQueryResult
            {
                LocationCount = values
            };

        }
    }
}
