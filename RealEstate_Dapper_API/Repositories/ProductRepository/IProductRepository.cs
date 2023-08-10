using RealEstate_Dapper_API.Dtos.ProductDtos;

namespace RealEstate_Dapper_API.Repositories.ProductRepository
{
    public interface IProductRepository
    {
        Task<List<ResultProductDto>> GetAllProductAsync();
        Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoryAsync();
        //void AddCategoryAsync(CreateCategoryDto categoryDto);
        //void DeleteCategoryAsync(int id);
        //void UpdateCategoryAsync(UpdateCategoryDto categoryDto);
        //Task<GetByIDCategoryDto> GetCategory(int id);
    }
}
