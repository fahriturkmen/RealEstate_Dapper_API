using Dapper;
using RealEstate_Dapper_API.Dtos.ServiceDtos;
using RealEstate_Dapper_API.Models.DapperContext;

namespace RealEstate_Dapper_API.Repositories.ServiceRepositories
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly Context _context;

        public ServiceRepository(Context context)
        {
            _context=context;
        }
        public async void AddServiceAsync(CreateServiceDto serviceDto)
        {
            string query = "insert into Tbl_Service (ServiceName, ServiceStatus) values (@serviceName, @serviceStatus)";
            var parameters = new DynamicParameters();
            parameters.Add("@serviceName", serviceDto.ServiceName);
            parameters.Add("@serviceStatus", true);
            using (var connection = _context.createConnection())
            {
                var values = await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteServiceAsync(int id)
        {
            string query = "Delete From Tbl_Service Where ServiceID = @serviceId";
            var parameters = new DynamicParameters();
            parameters.Add("@serviceId", id);
            using (var connection = _context.createConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultServiceDto>> GetAllServiceAsync()
        {
            string query = "Select * From Tbl_Service";
            using (var connection = _context.createConnection())
            {
                var values = await connection.QueryAsync<ResultServiceDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIDServiceDto> GetService(int id)
        {
            string query = "Select * From Tbl_Service Where ServiceID = @serviceId";
            var parameters = new DynamicParameters();
            parameters.Add("@serviceId", id);
            using (var connection = _context.createConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIDServiceDto>(query, parameters);
                return values;
            }
        }

        public async void UpdateServiceAsync(UpdateServiceDto serviceDto)
        {
            string query = "Update Tbl_Service Set ServiceName=@serviceName, ServiceStatus=@serviceStatus where ServiceID=@serviceId";
            var parameters = new DynamicParameters();
            parameters.Add("@serviceName", serviceDto.ServiceName);
            parameters.Add("@serviceStatus", serviceDto.ServiceStatus);
            parameters.Add("@serviceId", serviceDto.ServiceId);
            using (var connection = _context.createConnection())
            {
                var values = await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
