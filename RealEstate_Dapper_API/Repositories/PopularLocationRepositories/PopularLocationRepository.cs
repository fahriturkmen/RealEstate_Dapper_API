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
        public async void AddPopularLocationAsync(CreatePopularLocationDto createPopularLocationDto)
        {
            string query = "insert into Tbl_PopularLocation (CityName, ImageURL, LocationStatus) values (@cityName, @imageURL, @locationStatus)";
            var parameters = new DynamicParameters();
            parameters.Add("@cityName", createPopularLocationDto.CityName);
            parameters.Add("@imageURL", createPopularLocationDto.ImageURL);
            parameters.Add("@locationStatus", true);
            using (var connection = _context.createConnection())
            {
                var values = await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeletePopularLocationAsync(int id)
        {
            string query = "Delete From Tbl_PopularLocation Where LocationID = @locationId";
            var parameters = new DynamicParameters();
            parameters.Add("@locationId", id);
            using (var connection = _context.createConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
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

        public async Task<GetPopularLocationDto> GetPopularLocation(int id)
        {
            string query = "Select * From Tbl_PopularLocation Where locationID = @locationId";
            var parameters = new DynamicParameters();
            parameters.Add("@locationId", id);
            using (var connection = _context.createConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetPopularLocationDto>(query, parameters);
                return values;
            }
        }

        public async void UpdatePopularLocationAsync(UpdatePopularLocationDto updatePopularLocationDto)
        {
            string query = "Update Tbl_PopularLocation Set CityName=@cityName, ImageURL=@imageURL, LocationStatus=@locationStatus where LocationID=@locationId";
            var parameters = new DynamicParameters();
            parameters.Add("@cityName", updatePopularLocationDto.CityName);
            parameters.Add("@imageURL", updatePopularLocationDto.ImageURL);
            parameters.Add("@locationStatus", updatePopularLocationDto.LocationStatus);
            parameters.Add("@locationId", updatePopularLocationDto.LocationID);
            using (var connection = _context.createConnection())
            {
                var values = await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
