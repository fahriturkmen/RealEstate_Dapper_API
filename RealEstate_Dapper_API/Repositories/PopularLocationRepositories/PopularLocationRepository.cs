using Dapper;
using RealEstate_Dapper_API.Dtos.PopularLocationDtos;
using RealEstate_Dapper_API.Models.DapperContext;

namespace RealEstate_Dapper_API.Repositories.PopularLocationRepositories
{
    public class PopularLocationRepository : IPopularLocationRepository
    {
        private readonly Context _context;

        public PopularLocationRepository(Context context)
        {
            _context=context;
        }
        public void AddPopularLocationAsync(CreatePopularLocationDto createPopularLocationDto)
        {
            throw new NotImplementedException();
        }

        public void DeletePopularLocationAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultPopularLocationDto>> GetAllPopularLocationAsync()
        {
            string query = "Select * From Tbl_PopularLocation";
            using (var connection = _context.createConnection())
            {
                var values = await connection.QueryAsync<ResultPopularLocationDto>(query);
                return values.ToList();
            }
        }

        public Task<GetPopularLocationDto> GetPopularLocation(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdatePopularLocationAsync(UpdatePopularLocationDto updatePopularLocationDto)
        {
            throw new NotImplementedException();
        }
    }
}
