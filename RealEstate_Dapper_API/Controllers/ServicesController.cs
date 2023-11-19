using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_API.Dtos.ServiceDtos;
using RealEstate_Dapper_API.Repositories.ServiceRepositories;

namespace RealEstate_Dapper_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly IServiceRepository _serviceRepository;

        public ServicesController(IServiceRepository serviceRepository)
        {
            _serviceRepository=serviceRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetServicesList()
        {
            var values = await _serviceRepository.GetAllServiceAsync();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetServices(int id)
        {
            var values = await _serviceRepository.GetService(id);
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateServices(CreateServiceDto createServiceDto)
        {
            _serviceRepository.AddServiceAsync(createServiceDto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteServices(int id)
        {
            _serviceRepository.DeleteServiceAsync(id);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateServices(UpdateServiceDto updateServiceDto)
        {
            _serviceRepository.UpdateServiceAsync(updateServiceDto);
            return Ok();
        }
    }
}
