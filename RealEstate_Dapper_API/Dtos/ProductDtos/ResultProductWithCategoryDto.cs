﻿namespace RealEstate_Dapper_API.Dtos.ProductDtos
{
    public class ResultProductWithCategoryDto
    {
        public int ProductID { get; set; }
        public string ProductTitle { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductCoverImage { get; set; }
        public string ProductCity { get; set; }
        public string ProductDistrict { get; set; }
        public string ProductAdress { get; set; }
        public string ProductDescription { get; set; }
        public string ProductType { get; set; }
        public string ProductCategoryName { get; set; }
        public int ProductEmployeeID { get; set; }
        public bool ProductDealofTheDay { get; set; }
        public bool ProductStatus { get; set; }
    }
}
