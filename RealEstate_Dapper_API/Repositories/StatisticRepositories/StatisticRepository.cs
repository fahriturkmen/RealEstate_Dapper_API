using Dapper;
using RealEstate_Dapper_API.Models.DapperContext;

namespace RealEstate_Dapper_API.Repositories.StatisticRepositories
{
    public class StatisticRepository : IStatisticRepository
    {
        private readonly Context _context;

        public StatisticRepository(Context context)
        {
            _context=context;
        }
        public  int ActiveCategoryCount()
        {
            string query = "Select Count(*) From Tbl_Category Where CategoryStatus=1";
            using (var connection = _context.createConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);
                return values;
            }
        }

        public int ActiveEmployeeCount()
        {
            string query = "Select Count(*) From Tbl_Employee Where EmployeeStatus=1";
            using (var connection = _context.createConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);
                return values;
            }
        }

        public int ApartmentCount()
        {
            string query = "Select Count(*) From Tbl_Product Where ProductTitle like '%Daire%'";
            using (var connection = _context.createConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);
                return values;
            }
        }

        public decimal AveragePriceRentProduct()
        {
            string query = "Select Avg(ProductPrice) From Tbl_Product where ProductType='Kiralık'";
            using (var connection = _context.createConnection())
            {
                var values = connection.QueryFirstOrDefault<decimal>(query);
                return values;
            }
        }

        public decimal AveragePriceSaleProduct()
        {
            string query = "Select Avg(ProductPrice) From Tbl_Product where ProductType='Satılık'";
            using (var connection = _context.createConnection())
            {
                var values = connection.QueryFirstOrDefault<decimal>(query);
                return values;
            }
        }

        public int AverageRoomCount()
        {
            string query = "Select Avg(ProductRoomCount) From Tbl_ProductDetails";
            using (var connection = _context.createConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);
                return values;
            }
        }

        public int CategoryCount()
        {
            string query = "Select Count(*) From Tbl_Category";
            using (var connection = _context.createConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);
                return values;
            }
        }

        public string CategoryNameByMaxSalesCount()
        {
            string query = "Select top(1) CategoryName, Count(*) as Sayi from Tbl_Product Inner Join Tbl_Category On Tbl_Product.ProductCategory=Tbl_Category.CategoryID group by CategoryName order by Sayi Desc";
            using (var connection = _context.createConnection())
            {
                var values = connection.QueryFirstOrDefault<string>(query);
                return values;
            }
        }

        public string CityName_MaxSalesCount()
        {
            string query = "Select Top(1) ProductCity, Count(*) as Ilan_Sayisi From Tbl_Product Group By ProductCity order by Ilan_Sayisi Desc";
            using (var connection = _context.createConnection())
            {
                var values = connection.QueryFirstOrDefault<string>(query);
                return values;
            }
        }

        public string EmployeeNameByMaxSalesCount()
        {
            string query = "Select EmployeeName,Count(*) As Sales_Count from Tbl_Product Inner Join Tbl_Employee On Tbl_Product.ProductEmployeeID=Tbl_Employee.EmployeeID Group By EmployeeName Order By Sales_Count Desc";
            using (var connection = _context.createConnection())
            {
                var values = connection.QueryFirstOrDefault<string>(query);
                return values;
            }
        }

        public int GroupByCityName_Count()
        {
            string query = "Select Count(Distinct(ProductCity)) From Tbl_Product";
            using (var connection = _context.createConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);
                return values;
            }
        }

        public decimal LastAddedProductPrice()
        {
            string query = "Select Top(1) ProductPrice From Tbl_Product Order By ProductID Desc";
            using (var connection = _context.createConnection())
            {
                var values = connection.QueryFirstOrDefault<decimal>(query);
                return values;
            }
        }

        public string NewestBuildingYear()
        {
            string query = "Select Top(1) ProductBuildYear From Tbl_ProductDetails Order By ProductBuildYear Desc";
            using (var connection = _context.createConnection())
            {
                var values = connection.QueryFirstOrDefault<string>(query);
                return values;
            }
        }

        public string OldestBuildingYear()
        {
            string query = "Select Top(1) ProductBuildYear From Tbl_ProductDetails Order By ProductBuildYear";
            using (var connection = _context.createConnection())
            {
                var values = connection.QueryFirstOrDefault<string>(query);
                return values;
            }
        }

        public int PassiveCategoryCount()
        {
            string query = "Select Count(*) From Tbl_Category Where CategoryStatus=0";
            using (var connection = _context.createConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);
                return values;
            }
        }

        public int ProductCount()
        {
            string query = "Select Count(*) From Tbl_Product";
            using (var connection = _context.createConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);
                return values;
            }
        }
    }
}
