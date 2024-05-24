using ProSkills.Models.ClientSide;

namespace ProSkills.ViewModels
{
    public static class MappingExtensions
    {
        public static Trainee ToTrainee(this RegisterUserViewModel model)
        {
            return new Trainee
            {
                Name = model.UserName,
                Email = model.Email,
                Password = model.Password,
                Phone = model.Phone,
                country = model.country,
                CreatedAt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                IsDeleted = false
            };
        }
    }

}
