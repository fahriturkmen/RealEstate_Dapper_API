﻿namespace RealEstate_Dapper_API.Dtos.PopularLocationDtos
{
    public class ResultPopularLocationDto
    {
        public int LocationID { get; set; }
        public string CityName { get; set; }
        public string ImageURL { get; set; }
        public bool LocationStatus { get; set; }
    }
}
