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
            throw new NotImplementedException();
        }

        public string EmployeeNameByMaxSalesCount()
        {
            throw new NotImplementedException();
        }

        public string GroupByCityName_SalesCount()
        {
            throw new NotImplementedException();
        }

        public int LastAddedProductPrice()
        {
            throw new NotImplementedException();
        }

        public string NewestBuildingYear()
        {
            throw new NotImplementedException();
        }

        public string OldestBuildingYear()
        {
            throw new NotImplementedException();
        }

        public int PassiveCategoryCount()
        {
            throw new NotImplementedException();
        }

        public int ProductCount()
        {
            throw new NotImplementedException();
        }
    }
}
