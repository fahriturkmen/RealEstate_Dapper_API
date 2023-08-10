namespace RealEstate_Dapper_API.Dtos.ProductDtos
{
    public class ResultProductDto
    {
        public int ProductID { get; set; }
        public string ProductTitle { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductCity { get; set; }
        public string ProductDistrict { get; set; }
        public string ProductAdress { get; set; }
        public string ProductDescription { get; set; }
        public int ProductCategory { get; set; }
        public int ProductEmployeeID { get; set; }
        public bool ProductStatus { get; set; }
    }
}
