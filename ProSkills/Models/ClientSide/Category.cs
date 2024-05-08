using System.Drawing;

namespace ProSkills.Models.ClientSide
{
    public class Category
    {
        
            public int Id { get; set; }
            public string Name { get; set; }
            public string CreatedAt{ get; set;}
            public string Image { get; set; }
     
            public bool IsDeleted { get; set;}
    }
}

