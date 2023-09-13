using RealEstate_Dapper_API.Dtos.PopularLocationDtos;

namespace RealEstate_Dapper_API.Repositories.PopularLocationRepositories
{
    public interface IPopularLocationRepository
    {
        Task<List<ResultPopularLocationDto>> GetAllPopularLocationAsync();
        void AddPopularLocationAsync(CreatePopularLocationDto createPopularLocationDto);
        void DeletePopularLocationAsync(int id);
        void UpdatePopularLocationAsync(UpdatePopularLocationDto updatePopularLocationDto);
        Task<GetPopularLocationDto> GetPopularLocation(int id);
    }
}
