using Dapper;
using RealEstate_Dapper_API.Dtos.EmployeeDtos;
using RealEstate_Dapper_API.Models.DapperContext;

namespace RealEstate_Dapper_API.Repositories.EmployeeRepositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly Context _context;

        public EmployeeRepository(Context context)
        {
            _context=context;
        }
        public async void AddEmployeeAsync(CreateEmployeeDto employeeDto)
        {
            string query = "insert into Tbl_Employee (EmployeeName, EmployeeTitle, EmployeeMail, EmployeePhoneNumber, EmployeeComment, EmployeeImageURL, EmployeeStatus) values (@employeeName, @employeeTitle, @employeeMail, @employeePhoneNumber, @employeeComment, @employeeImageURL, @employeeStatus)";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeName", employeeDto.EmployeeName);
            parameters.Add("@employeeTitle", employeeDto.EmployeeTitle);
            parameters.Add("@employeeMail", employeeDto.EmployeeMail);
            parameters.Add("@employeePhoneNumber", employeeDto.EmployeePhoneNumber);
            parameters.Add("@employeeComment", employeeDto.EmployeeComment);
            parameters.Add("@employeeImageURL", employeeDto.EmployeeImageURL);
            parameters.Add("@employeeStatus", true);
            using (var connection = _context.createConnection())
            {
                var values = await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteEmployeeAsync(int id)
        {
            string query = "Delete From Tbl_Employee Where EmployeeID = @employeeID";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeID", id);
            using (var connection = _context.createConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultEmployeeDto>> GetAllEmployeeAsync()
        {
            string query = "Select * From Tbl_Employee";
            using (var connection = _context.createConnection())
            {
                var values = await connection.QueryAsync<ResultEmployeeDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIDEmployeeDto> GetEmployee(int id)
        {
            string query = "Select * From Tbl_Employee Where EmployeeID = @employeeID";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeID", id);
            using (var connection = _context.createConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIDEmployeeDto>(query, parameters);
                return values;
            }
        }

        public async void UpdateEmployeeAsync(UpdateEmployeeDto employeeDto)
        {
            string query = "Update Tbl_Employee Set EmployeeName=@employeeName, EmployeeTitle=@employeeTitle, EmployeeMail=@employeeMail, EmployeePhoneNumber=@employeePhoneNumber, EmployeeComment=@employeeComment, EmployeeImageURL=@employeeImageURL, EmployeeStatus=@employeeStatus where EmployeeID=@employeeID";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeName", employeeDto.EmployeeName);
            parameters.Add("@employeeTitle", employeeDto.EmployeeTitle);
            parameters.Add("@employeeMail", employeeDto.EmployeeMail);
            parameters.Add("@employeePhoneNumber", employeeDto.EmployeePhoneNumber);
            parameters.Add("@employeeComment", employeeDto.EmployeeComment);
            parameters.Add("@employeeImageURL", employeeDto.EmployeeImageURL);
            parameters.Add("@employeeStatus", employeeDto.EmployeeStatus);
            parameters.Add("@employeeID", employeeDto.EmployeeID);
            using (var connection = _context.createConnection())
            {
                var values = await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
