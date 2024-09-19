using CarBook.Dto.StatisticsDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.ViewComponents.DashboardComponents
{
    public class _AdminDashboardStatisticsComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _AdminDashboardStatisticsComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            Random random = new Random();
            var client = _httpClientFactory.CreateClient();

            #region istatistik1

            var responseMessage1 = await client.GetAsync("https://localhost:7297/api/Statistics/GetCarCount");
            if (responseMessage1.IsSuccessStatusCode)
            {
                int r1 = random.Next(0, 101);
                var jsonData = await responseMessage1.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.v1 = values?.carCount;
                ViewBag.r1 = r1;
            }
            #endregion

            #region istatistik2

            var responseMessage2 = await client.GetAsync("https://localhost:7297/api/Statistics/GetLocationCount");
            if (responseMessage2.IsSuccessStatusCode)
            {
                int r2 = random.Next(0, 101);
                var jsonData = await responseMessage2.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.v2 = values?.locationCount;
                ViewBag.r2 = r2;
            }
            #endregion

            #region istatistik3

            var responseMessage3 = await client.GetAsync("https://localhost:7297/api/Statistics/GetBrandCount");
            if (responseMessage3.IsSuccessStatusCode)
            {
                int r3 = random.Next(0, 101);
                var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData3);
                ViewBag.v3 = values?.brandCount;
                ViewBag.r3 = r3;
            }
            #endregion

            #region istatistik4

            var responseMessage4 = await client.GetAsync("https://localhost:7297/api/Statistics/GetAvgRentPriceForDaily");
            if (responseMessage4.IsSuccessStatusCode)
            {
                int r4 = random.Next(0, 101);
                var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData4);
                ViewBag.v4 = values?.avgRentPriceForDaily.ToString("0.00");
                ViewBag.r4 = r4;
            }
            #endregion

            return View();
        }
    }
}
