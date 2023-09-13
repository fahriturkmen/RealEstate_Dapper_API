using RealEstate_Dapper_API.Dtos.TestimonialDtos;

namespace RealEstate_Dapper_API.Repositories.TestimonialRepositories
{
    public interface ITestimonialRepository
    {
        Task<List<ResultTestimonialDto>> GetAllTestimonialAsync();
        void AddTestimonialAsync(CreateTestimonialDto createTestimonialDto);
        void DeleteTestimonialAsync(int id);
        void UpdateTestimonialAsync(UpdateTestimonialDto updateTestimonialDto);
        Task<GetTestimonialDto> GetTestimonial(int id);
    }
}
