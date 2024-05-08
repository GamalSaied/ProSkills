using System.ComponentModel.DataAnnotations.Schema;

namespace ProSkills.Models.ClientSide
{
    public class Lesson
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Content { get; set; }

        [ForeignKey("ModuleId")]

        public int ModuleId { get; set; }
        public Module Module { get; set; }




    }
}
