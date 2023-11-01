using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_UI.Controllers
{
    public class StatisticController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public StatisticController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory=httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            #region AktifKategori
                var client = _httpClientFactory.CreateClient();
                var responseMessage = await client.GetAsync("https://localhost:7007/api/Statistics/ActiveCategoryCount");
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                ViewBag.activeCategoryCount = jsonData;
            #endregion

            #region AktifCalisan
                var client2 = _httpClientFactory.CreateClient();
                var responseMessage2 = await client2.GetAsync("https://localhost:7007/api/Statistics/ActiveEmployeeCount");
                var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
                ViewBag.activeEmployeeCount = jsonData2;
            #endregion

            #region DaireSayisi 
                var client3 = _httpClientFactory.CreateClient();
                var responseMessage3 = await client3.GetAsync("https://localhost:7007/api/Statistics/ApartmentCount");
                var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
                ViewBag.apartmentCount = jsonData3;
            #endregion

            #region KiraOrtalamasi 
                var client4 = _httpClientFactory.CreateClient();
                var responseMessage4 = await client4.GetAsync("https://localhost:7007/api/Statistics/AveragePriceRentProduct");
                var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
                ViewBag.averagePriceRentProduct = jsonData4;
            #endregion

            #region SatilikOrtalamasi
                var client5 = _httpClientFactory.CreateClient();
                var responseMessage5 = await client5.GetAsync("https://localhost:7007/api/Statistics/AveragePriceSaleProduct");
                var jsonData5 = await responseMessage5.Content.ReadAsStringAsync();
                ViewBag.averagePriceSaleProduct = jsonData5;
            #endregion

            #region OrtalamaOdaSayisi
                var client6 = _httpClientFactory.CreateClient();
                var responseMessage6 = await client6.GetAsync("https://localhost:7007/api/Statistics/AverageRoomCount");
                var jsonData6 = await responseMessage6.Content.ReadAsStringAsync();
                ViewBag.averageRoomCount = jsonData6;
            #endregion

            #region KategoriSayisi 
                var client7 = _httpClientFactory.CreateClient();
                var responseMessage7 = await client7.GetAsync("https://localhost:7007/api/Statistics/CategoryCount");
                var jsonData7 = await responseMessage7.Content.ReadAsStringAsync();
                ViewBag.categoryCount = jsonData7;
            #endregion

            #region EnCokSatisiOlanKategori 
                var client8 = _httpClientFactory.CreateClient();
                var responseMessage8 = await client8.GetAsync("https://localhost:7007/api/Statistics/CategoryNameByMaxSalesCount");
                var jsonData8 = await responseMessage8.Content.ReadAsStringAsync();
                ViewBag.categoryNameByMaxSalesCount = jsonData8;
            #endregion

            #region EnCokSatisSehir
                var client9 = _httpClientFactory.CreateClient();
                var responseMessage9 = await client9.GetAsync("https://localhost:7007/api/Statistics/CityName_MaxSalesCount");
                var jsonData9 = await responseMessage9.Content.ReadAsStringAsync();
                ViewBag.cityName_MaxSalesCount = jsonData9;
            #endregion

            #region SehirSatislari
                var client10 = _httpClientFactory.CreateClient();
                var responseMessage10 = await client10.GetAsync("https://localhost:7007/api/Statistics/GroupByCityName_Count");
                var jsonData10 = await responseMessage10.Content.ReadAsStringAsync();
                ViewBag.groupByCityName_Count = jsonData10;
            #endregion

            #region EnCokSatisiOlanEleman 
                var client11 = _httpClientFactory.CreateClient();
                var responseMessage11 = await client11.GetAsync("https://localhost:7007/api/Statistics/EmployeeNameByMaxSalesCount");
                var jsonData11 = await responseMessage11.Content.ReadAsStringAsync();
                ViewBag.employeeNameByMaxSalesCount = jsonData11;
            #endregion

            #region SonEkleneninFiyati 
                var client12 = _httpClientFactory.CreateClient();
                var responseMessage12 = await client12.GetAsync("https://localhost:7007/api/Statistics/LastAddedProductPrice");
                var jsonData12 = await responseMessage12.Content.ReadAsStringAsync();
                ViewBag.lastAddedProductPrice = jsonData12;
            #endregion

            #region EnYeniBina
                var client13 = _httpClientFactory.CreateClient();
                var responseMessage13 = await client13.GetAsync("https://localhost:7007/api/Statistics/NewestBuildingYear");
                var jsonData13 = await responseMessage13.Content.ReadAsStringAsync();
                ViewBag.newestBuildingYear = jsonData13;
            #endregion

            #region EnEskiBina
                var client14 = _httpClientFactory.CreateClient();
                var responseMessage14 = await client14.GetAsync("https://localhost:7007/api/Statistics/OldestBuildingYear");
                var jsonData14 = await responseMessage14.Content.ReadAsStringAsync();
                ViewBag.oldestBuildingYear = jsonData14;
            #endregion

            #region PasifKategoriSayisi 
                var client15 = _httpClientFactory.CreateClient();
                var responseMessage15 = await client15.GetAsync("https://localhost:7007/api/Statistics/PassiveCategoryCount");
                var jsonData15 = await responseMessage15.Content.ReadAsStringAsync();
                ViewBag.passiveCategoryCount = jsonData15;
            #endregion

            #region EmlakSayisi
                var client16 = _httpClientFactory.CreateClient();
                var responseMessage16 = await client16.GetAsync("https://localhost:7007/api/Statistics/ProductCount");
                var jsonData16 = await responseMessage16.Content.ReadAsStringAsync();
                ViewBag.productCount = jsonData16;
            #endregion

            return View();

        }
    }
}
