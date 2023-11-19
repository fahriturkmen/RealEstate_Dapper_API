using Dapper;
using RealEstate_Dapper_API.Dtos.ProductDtos;
using RealEstate_Dapper_API.Models.DapperContext;

namespace RealEstate_Dapper_API.Repositories.ProductRepositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly Context _context;

        public ProductRepository(Context context)
        {
            _context=context;
        }
        public async Task<List<ResultProductDto>> GetAllProductAsync()
        {
            string query = "Select * From Tbl_Product";
            using (var connection = _context.createConnection())
            {
                var values = await connection.QueryAsync<ResultProductDto>(query);
                return values.ToList();
            }
        }

        public async Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoryAsync()
        {
            string query = "Select ProductID,ProductTitle,ProductPrice,ProductCoverImage,ProductCity,ProductDistrict,ProductAdress,ProductDescription,ProductType,Tbl_Category.CategoryName AS ProductCategoryName,ProductEmployeeID,ProductStatus,ProductDealofTheDay From Tbl_Product inner join Tbl_Category on Tbl_Product.ProductCategory=Tbl_Category.CategoryID";
            using (var connection = _context.createConnection())
            {
                var values = await connection.QueryAsync<ResultProductWithCategoryDto>(query);
                return values.ToList();
            }
        }
    }
}