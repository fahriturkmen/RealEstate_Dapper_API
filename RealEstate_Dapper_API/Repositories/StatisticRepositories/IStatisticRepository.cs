﻿using RealEstate_Dapper_API.Dtos.StatisticDtos;

namespace RealEstate_Dapper_API.Repositories.StatisticRepositories
{
    public interface IStatisticRepository
    {
        int CategoryCount();
        int ActiveCategoryCount();
        int PassiveCategoryCount();
        int ProductCount();
        int ApartmentCount();
        string EmployeeNameByMaxSalesCount();
        string CategoryNameByMaxSalesCount();
        decimal AveragePriceRentProduct();
        decimal AveragePriceSaleProduct();
        string CityName_MaxSalesCount();
        string GroupByCityName_SalesCount();
        int LastAddedProductPrice();
        string NewestBuildingYear();
        string OldestBuildingYear();
        int AverageRoomCount();
        int ActiveEmployeeCount();

    }
}
