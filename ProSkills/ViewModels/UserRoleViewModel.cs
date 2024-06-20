namespace ProSkills.ViewModels
{
    public class UserRoleViewModel
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public List<string>? Roles { get; set; }
        public string? SelectedRole { get; set; }
        public List<string>? AllRoles { get; set; }
    }

}
