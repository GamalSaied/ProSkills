using System.ComponentModel.DataAnnotations.Schema;

namespace ProSkills.Models
{
    public class Trainee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public float Grade { get; set; }
        public string Address { get; set; }



        public List<CrsResult> CrsResults { get; set; }

    }
}
