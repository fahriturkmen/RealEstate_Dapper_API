using RealEstate_Dapper_API.Dtos.WhoWeAreDetailDtos;

namespace RealEstate_Dapper_API.Repositories.WhoWeAreRepositories
{
    public interface IWhoWeAreRepository
    {
        Task<List<ResultWhoWeAreDetailDto>> GetAllWhoWeAreDetailAsync();
        void AddWhoWeAreDetailAsync(CreateWhoWeAreDetailDto addWhoWeAreDetailDto);
        void DeleteWhoWeAreDetailAsync(int id);
        void UpdateWhoWeAreDetailAsync(UpdateWhoWeAreDetailDto updateWhoWeAreDetailDto);
        Task<GetByIDWhoWeAreDetailDto> GetwhoWeAreDetail(int id);
    }
}
