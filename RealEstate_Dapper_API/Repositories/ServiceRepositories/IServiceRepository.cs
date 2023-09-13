using RealEstate_Dapper_API.Dtos.ServiceDtos;

namespace RealEstate_Dapper_API.Repositories.ServiceRepositories
{
    public interface IServiceRepository
    {
        Task<List<ResultServiceDto>> GetAllServiceAsync();
        void AddServiceAsync(CreateServiceDto serviceDto);
        void DeleteServiceAsync(int id);
        void UpdateServiceAsync(UpdateServiceDto serviceDto);
        Task<GetByIDServiceDto> GetService(int id);
    }
}
