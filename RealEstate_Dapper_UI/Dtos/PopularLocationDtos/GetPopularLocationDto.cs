﻿namespace RealEstate_Dapper_UI.Dtos.PopularLocationDtos
{
    public class GetPopularLocationDto
    {
        public int LocationID { get; set; }
        public string CityName { get; set; }
        public string ImageURL { get; set; }
        public bool LocationStatus { get; set; }
    }
}