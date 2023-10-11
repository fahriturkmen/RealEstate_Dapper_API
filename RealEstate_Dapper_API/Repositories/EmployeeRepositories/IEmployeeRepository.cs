using RealEstate_Dapper_API.Dtos.EmployeeDtos;

namespace RealEstate_Dapper_API.Repositories.EmployeeRepositories
{
    public interface IEmployeeRepository
    {
        Task<List<ResultEmployeeDto>> GetAllEmployeeAsync();
        void AddEmployeeAsync(CreateEmployeeDto employeeDto);
        void DeleteEmployeeAsync(int id);
        void UpdateEmployeeAsync(UpdateEmployeeDto employeeDto);
        Task<GetByIDEmployeeDto> GetEmployee(int id);
    }
}
