using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace ProSkills.Models.ClientSide
{
    public class Category
    {
            [Key]
            public int Id { get; set; }
            public string Name { get; set; }

            public string Image { get; set; }

            public string? CreatedAt { get; set; }
            public bool? IsDeleted { get; set; } = false;
    }
}

