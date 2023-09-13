namespace RealEstate_Dapper_API.Dtos.TestimonialDtos
{
    public class CreateTestimonialDto
    {
        public string ClientNameSurname { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public bool TestimonialStatus { get; set; }
    }
}
