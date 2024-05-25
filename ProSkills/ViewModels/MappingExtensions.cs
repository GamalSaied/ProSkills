using ProSkills.Models.ClientSide;

namespace ProSkills.ViewModels
{
    public static class MappingExtensions
    {
        public static Trainee ToTrainee(this RegisterUserViewModel model)
        {
            return new Trainee
            {
               
                Name = model.FullName,
                Email = model.Email,
               
                Phone = model.Phone,
                Country = model.Country,
                CreatedAt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                IsDeleted = false
            };
        }
    }

}
