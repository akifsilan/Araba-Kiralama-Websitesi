using CarBook.Dto.StatisticsDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/AdminStatistics")]
    public class AdminStatisticsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public AdminStatisticsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [Route("Index")]
        public async Task<IActionResult> Index()
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

            var responseMessage3 = await client.GetAsync("https://localhost:7297/api/Statistics/GetAuthorCount");
            if (responseMessage3.IsSuccessStatusCode)
            {
                int r3 = random.Next(0, 101);
                var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData3);
                ViewBag.v3 = values?.authorCount;
                ViewBag.r3 = r3;
            }

            #endregion

            #region istatistik4

            var responseMessage4 = await client.GetAsync("https://localhost:7297/api/Statistics/GetBlogCount");
            if (responseMessage4.IsSuccessStatusCode)
            {
                int r4 = random.Next(0, 101);
                var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData4);
                ViewBag.v4 = values?.blogCount;
                ViewBag.r4 = r4;
            }
            #endregion

            #region istatistik5

            var responseMessage5 = await client.GetAsync("https://localhost:7297/api/Statistics/GetBrandCount");
            if (responseMessage5.IsSuccessStatusCode)
            {
                int r5 = random.Next(0, 101);
                var jsonData5 = await responseMessage5.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData5);
                ViewBag.v5 = values?.brandCount;
                ViewBag.r5 = r5;
            }

            #endregion

            #region istatistik6

            var responseMessage6 = await client.GetAsync("https://localhost:7297/api/Statistics/GetAvgRentPriceForDaily");
            if (responseMessage6.IsSuccessStatusCode)
            {
                int r6 = random.Next(0, 101);
                var jsonData6 = await responseMessage6.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData6);
                ViewBag.v6 = values?.avgRentPriceForDaily.ToString("0.00");
                ViewBag.r6 = r6;
            }

            #endregion

            #region istatistik7

            var responseMessage7 = await client.GetAsync("https://localhost:7297/api/Statistics/GetAvgRentPriceForWeekly");
            if (responseMessage7.IsSuccessStatusCode)
            {
                int r7 = random.Next(0, 101);
                var jsonData7 = await responseMessage7.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData7);
                ViewBag.v7 = values?.avgRentPriceForWeekly.ToString("0.00");
                ViewBag.r7 = r7;
            }

            #endregion

            #region istatistik8

            var responseMessage8 = await client.GetAsync("https://localhost:7297/api/Statistics/GetAvgRentPriceForMonthly");
            if (responseMessage8.IsSuccessStatusCode)
            {
                int r8 = random.Next(0, 101);
                var jsonData8 = await responseMessage8.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData8);
                ViewBag.v8 = values?.avgRentPriceForMonthly.ToString("0.00");
                ViewBag.r8 = r8;
            }

            #endregion

            #region istatistik9

            var responseMessage9 = await client.GetAsync("https://localhost:7297/api/Statistics/GetCarCountByTransmissionIsAuto");
            if (responseMessage9.IsSuccessStatusCode)
            {
                int r9 = random.Next(0, 101);
                var jsonData9 = await responseMessage9.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData9);
                ViewBag.v9 = values?.carCountByTransmissionIsAuto;
                ViewBag.r9 = r9;
            }

            #endregion

            #region istatistik10

            var responseMessage10 = await client.GetAsync("https://localhost:7297/api/Statistics/GetBrandNameByMaxCar");
            if (responseMessage10.IsSuccessStatusCode)
            {
                int r10 = random.Next(0, 101);
                var jsonData10 = await responseMessage10.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData10);
                ViewBag.v10 = values?.brandNameByMaxCar;
                ViewBag.r10 = r10;
            }

            #endregion

            #region istatistik11

            var responseMessage11 = await client.GetAsync("https://localhost:7297/api/Statistics/GetBlogTitleByMaxBlogComment");
            if (responseMessage11.IsSuccessStatusCode)
            {
                int r11 = random.Next(0, 101);
                var jsonData11 = await responseMessage11.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData11);
                ViewBag.v11 = values?.blogTitleByMaxBlogComment;
                ViewBag.r11 = r11;
            }


            #endregion

            #region istatistik12

            var responseMessage12 = await client.GetAsync("https://localhost:7297/api/Statistics/GetCarCountByKmSmallerThen10000");
            if (responseMessage12.IsSuccessStatusCode)
            {
                int r12 = random.Next(0, 101);
                var jsonData12 = await responseMessage12.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData12);
                ViewBag.v12 = values?.carCountByKmSmallerThen10000;
                ViewBag.r12 = r12;
            }

            #endregion

            #region istatistik13

            var responseMessage13 = await client.GetAsync("https://localhost:7297/api/Statistics/GetCarCountByFuelGasolineOrDiesel");
            if (responseMessage13.IsSuccessStatusCode)
            {
                int r13 = random.Next(0, 101);
                var jsonData13 = await responseMessage13.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData13);
                ViewBag.v13 = values?.carCountByFuelGasolineOrDiesel;
                ViewBag.r13 = r13;
            }

            #endregion

            #region istatistik14

            var responseMessage14 = await client.GetAsync("https://localhost:7297/api/Statistics/GetCarCountByFuelElectric");
            if (responseMessage14.IsSuccessStatusCode)
            {
                int r14 = random.Next(0, 101);
                var jsonData14 = await responseMessage14.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData14);
                ViewBag.v14 = values?.carCountByFuelElectric;
                ViewBag.r14 = r14;
            }

            #endregion

            #region istatistik15

            var responseMessage15 = await client.GetAsync("https://localhost:7297/api/Statistics/GetCarBrandAndModelByRentPriceDailyMax");
            if (responseMessage15.IsSuccessStatusCode)
            {
                int r15 = random.Next(0, 101);
                var jsonData15 = await responseMessage15.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData15);
                ViewBag.v15 = values?.carBrandAndModelByRentPriceDailyMax;
                ViewBag.r15 = r15;
            }

            #endregion

            #region istatistik16

            var responseMessage16 = await client.GetAsync("https://localhost:7297/api/Statistics/GetCarBrandAndModelByRentPriceDailyMin");
            if (responseMessage16.IsSuccessStatusCode)
            {
                int r16 = random.Next(0, 101);
                var jsonData16 = await responseMessage16.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData16);
                ViewBag.v16 = values?.carBrandAndModelByRentPriceDailyMin;
                ViewBag.r16 = r16;
            }

            #endregion

            return View();
        }
    }
}