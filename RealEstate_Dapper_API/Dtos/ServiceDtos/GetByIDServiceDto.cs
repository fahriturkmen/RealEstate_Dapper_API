﻿namespace RealEstate_Dapper_API.Dtos.ServiceDtos
{
    public class GetByIDServiceDto
    {
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public bool ServiceStatus { get; set; }
    }
}
