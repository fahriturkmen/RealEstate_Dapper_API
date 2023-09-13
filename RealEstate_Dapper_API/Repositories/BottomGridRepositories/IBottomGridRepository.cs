using RealEstate_Dapper_API.Dtos.BottomGridDtos;

namespace RealEstate_Dapper_API.Repositories.BottomGridRepositories
{
    public interface IBottomGridRepository
    {
        Task<List<ResultBottomGridDto>> GetAllBottomGridAsync();
        void AddBottomGridAsync(CreateBottomGridDto createBottomGridDto);
        void DeleteBottomGridAsync(int id);
        void UpdateBottomGridAsync(UpdateBottomGridDto updateBottomGridDto);
        Task<GetBottomGridDto> GetBottomGrid(int id);
    }
}
