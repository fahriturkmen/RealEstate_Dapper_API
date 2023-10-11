﻿namespace RealEstate_Dapper_API.Dtos.EmployeeDtos
{
    public class CreateEmployeeDto
    {
        public string? EmployeeName { get; set; }
        public string? EmployeeTitle { get; set; }
        public string? EmployeeMail { get; set; }
        public string? EmployeePhoneNumber { get; set; }
        public string? EmployeeComment { get; set; }
        public string? EmployeeImageURL { get; set; }
        public bool EmployeeStatus { get; set; }
    }
}
