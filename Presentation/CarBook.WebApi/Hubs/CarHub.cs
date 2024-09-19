﻿using Microsoft.AspNetCore.SignalR;
using System;

namespace CarBook.WebApi.Hubs
{
    public class CarHub : Hub
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CarHub(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task SendCarCount()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage1 = await client.GetAsync("https://localhost:7297/api/Statistics/GetCarCount");
            var value = await responseMessage1.Content.ReadAsStringAsync();
            await Clients.All.SendAsync("ReceiveCarCount",value);
        }
    }
}