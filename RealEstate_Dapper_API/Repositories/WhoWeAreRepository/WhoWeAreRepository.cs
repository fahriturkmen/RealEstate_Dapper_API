using Dapper;
using RealEstate_Dapper_API.Dtos.WhoWeAreDetailDtos;
using RealEstate_Dapper_API.Models.DapperContext;

namespace RealEstate_Dapper_API.Repositories.WhoWeAreRepository
{
    public class WhoWeAreRepository : IWhoWeAreRepository
    {
        private readonly Context _context;

        public WhoWeAreRepository(Context context)
        {
            _context=context;
        }

        public async void AddWhoWeAreDetailAsync(CreateWhoWeAreDetailDto addWhoWeAreDetailDto)
        {
            string query = "insert into Tbl_WhoWeAreDetail (Title, Subtitle, Description1, Description2) values (@title, @subtitle, @description1, @description2)";
            var parameters = new DynamicParameters();
            parameters.Add("@title", addWhoWeAreDetailDto.Title);
            parameters.Add("@subtitle", addWhoWeAreDetailDto.Subtitle);
            parameters.Add("@description1", addWhoWeAreDetailDto.Description1);
            parameters.Add("@description2", addWhoWeAreDetailDto.Description2);
            using (var connection = _context.createConnection())
            {
                var values = await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteWhoWeAreDetailAsync(int id)
        {
            string query = "Delete From Tbl_WhoWeAreDetail Where WhoWeAreDetailID = @whoWeAreDetailID";
            var parameters = new DynamicParameters();
            parameters.Add("@whoWeAreDetailID", id);
            using (var connection = _context.createConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultWhoWeAreDetailDto>> GetAllWhoWeAreDetailAsync()
        {
            string query = "Select * From Tbl_WhoWeAreDetail";
            using (var connection = _context.createConnection())
            {
                var values = await connection.QueryAsync<ResultWhoWeAreDetailDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIDWhoWeAreDetailDto> GetwhoWeAreDetail(int id)
        {
            string query = "Select * From Tbl_WhoWeAreDetail Where WhoWeAreDetailID = @whoWeAreDetailID";
            var parameters = new DynamicParameters();
            parameters.Add("@whoWeAreDetailID", id);
            using (var connection = _context.createConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIDWhoWeAreDetailDto>(query, parameters);
                return values;
            }
        }

        public async void UpdateWhoWeAreDetailAsync(UpdateWhoWeAreDetailDto updateWhoWeAreDetailDto)
        {
            string query = "Update Tbl_WhoWeAreDetail Set Title=@title, Subtitle=@subtitle, Description1=@description1, Description2=@description2 where WhoWeAreDetailID=@whoWeAreDetailID";
            var parameters = new DynamicParameters();
            parameters.Add("@title", updateWhoWeAreDetailDto.Title);
            parameters.Add("@subtitle", updateWhoWeAreDetailDto.Subtitle);
            parameters.Add("@description1", updateWhoWeAreDetailDto.Description1);
            parameters.Add("@description2", updateWhoWeAreDetailDto.Description2);
            parameters.Add("@whoWeAreDetailID", updateWhoWeAreDetailDto.WhoWeAreDetailID);
            using (var connection = _context.createConnection())
            {
                var values = await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
