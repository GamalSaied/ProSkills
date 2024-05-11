using System.ComponentModel.DataAnnotations;

namespace ProSkills.Models.ClientSide
{
    public class RedeemCode
    {
        [Key]
        public int Id { get; set; }
        public string Code { get; set; }
        public int packageid { get; set; }
        public string PackageName { get; set; }
       
        public string? CreatedAt { get; set; }
        public bool? IsDeleted { get; set; } = false;
    }
}

