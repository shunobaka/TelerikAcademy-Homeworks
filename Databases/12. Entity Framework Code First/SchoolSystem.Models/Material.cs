namespace SchoolSystem.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Material
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public string Description { get; set; }

        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
    }
}
