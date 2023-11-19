using Dapper;
using RealEstate_Dapper_API.Dtos.BottomGridDtos;
using RealEstate_Dapper_API.Models.DapperContext;

namespace RealEstate_Dapper_API.Repositories.BottomGridRepositories
{
    public class BottomGridRepository : IBottomGridRepository
    {
        private readonly Context _context;

        public BottomGridRepository(Context context)
        {
            _context=context;
        }
        public async void AddBottomGridAsync(CreateBottomGridDto bottomGridDto)
        {
            string query = "insert into Tbl_BottomGrid (IconImage, Title, BG_Description, BottomGridStatus) values (@iconImage, @title, @bg_Description, @bottomGridStatus)";
            var parameters = new DynamicParameters();
            parameters.Add("@iconImage", bottomGridDto.IconImage);
            parameters.Add("@title", bottomGridDto.Title);
            parameters.Add("@bg_Description", bottomGridDto.BG_Description);
            parameters.Add("@bottomGridStatus", true);
            using (var connection = _context.createConnection())
            {
                var values = await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteBottomGridAsync(int id)
        {
            string query = "Delete From Tbl_BottomGrid Where BottomGridID = @bottomGridId";
            var parameters = new DynamicParameters();
            parameters.Add("@bottomGridId", id);
            using (var connection = _context.createConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultBottomGridDto>> GetAllBottomGridAsync()
        {
            string query = "Select * From Tbl_BottomGrid";
            using (var connection = _context.createConnection())
            {
                var values = await connection.QueryAsync<ResultBottomGridDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetBottomGridDto> GetBottomGrid(int id)
        {
            string query = "Select * From Tbl_BottomGrid Where BottomGridID = @bottomGridId";
            var parameters = new DynamicParameters();
            parameters.Add("@bottomGridId", id);
            using (var connection = _context.createConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetBottomGridDto>(query, parameters);
                return values;
            }
        }

        public async void UpdateBottomGridAsync(UpdateBottomGridDto BottomGridDto)
        {
            string query = "Update Tbl_BottomGrid Set IconImage=@iconImage, Title=@title, BG_Description=@bg_Description, BottomGridStatus=@bottomGridStatus where BottomGridID=@bottomGridId";
            var parameters = new DynamicParameters();
            parameters.Add("@iconImage", BottomGridDto.IconImage);
            parameters.Add("@title", BottomGridDto.Title);
            parameters.Add("@bg_Description", BottomGridDto.BG_Description);
            parameters.Add("@bottomGridStatus", BottomGridDto.BottomGridStatus);
            parameters.Add("@bottomGridId", BottomGridDto.BottomGridID);
            using (var connection = _context.createConnection())
            {
                var values = await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
