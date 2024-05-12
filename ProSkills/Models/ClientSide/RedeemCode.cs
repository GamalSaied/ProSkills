using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProSkills.Models.ClientSide
{
    public class RedeemCode
    {
        [Key]
        public int Id { get; set; }
        public string Code { get; set; }       
        public string? CreatedAt { get; set; }
        public bool? IsDeleted { get; set; } = false;
        public bool? isAvalible { get; set; } = true;

        [ForeignKey("Package")]
        public int packageid { get; set; }
        public string? PackageName { get; set; }
    }
}

