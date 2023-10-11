using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_API.Repositories.StatisticRepositories;

namespace RealEstate_Dapper_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly IStatisticRepository _statisticRepository;

        public StatisticsController(IStatisticRepository statisticRepository)
        {
            _statisticRepository=statisticRepository;
        }

        [HttpGet("ActiveCategoryCount")]
        public IActionResult ActiveCategoryCount()
        {
            return Ok(_statisticRepository.ActiveCategoryCount());
        }

        [HttpGet("ActiveEmployeeCount")]
        public IActionResult ActiveEmployeeCount()
        {
            return Ok(_statisticRepository.ActiveEmployeeCount());
        }

        [HttpGet("ApartmentCount")]
        public IActionResult ApartmentCount()
        {
            return Ok(_statisticRepository.ApartmentCount());
        }

        [HttpGet("AveragePriceRentProduct")]
        public IActionResult AveragePriceRentProduct()
        {
            return Ok(_statisticRepository.AveragePriceRentProduct());
        }
        
        [HttpGet("AveragePriceSaleProduct")]
        public IActionResult AveragePriceSaleProduct()
        {
            return Ok(_statisticRepository.AveragePriceSaleProduct());
        }

        [HttpGet("AverageRoomCount")]
        public IActionResult AverageRoomCount()
        {
            return Ok(_statisticRepository.AverageRoomCount());
        }

        [HttpGet("CategoryCount")]
        public IActionResult CategoryCount()
        {
            return Ok(_statisticRepository.CategoryCount());
        }

        [HttpGet("CategoryNameByMaxSalesCount")]
        public IActionResult CategoryNameByMaxSalesCount()
        {
            return Ok(_statisticRepository.CategoryNameByMaxSalesCount());
        }

        //[HttpGet("CategoryCount")]
        //public IActionResult CategoryCount()
        //{
        //    return Ok(_statisticRepository.CategoryCount());
        //}

        //[HttpGet("CategoryCount")]
        //public IActionResult CategoryCount()
        //{
        //    return Ok(_statisticRepository.CategoryCount());
        //}

        //[HttpGet("CategoryCount")]
        //public IActionResult CategoryCount()
        //{
        //    return Ok(_statisticRepository.CategoryCount());
        //}
    }
}
