namespace SchoolSystem.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Course
    {
        private ICollection<Material> materials;
        private ICollection<Student> students;

        public Course()
            : this(new HashSet<Material>(), new HashSet<Student>())
        {
        }

        public Course(ICollection<Material> materials, ICollection<Student> students)
        {
            this.Students = students;
            this.Materials = materials;
            this.Description = "No description for this course.";
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [MinLength(3)]
        public string Name { get; set; }

        [Required]
        [MinLength(10)]
        [MaxLength(200)]
        public string Description { get; set; }

        public virtual ICollection<Student> Students
        {
            get
            {
                return this.students;
            }
            set
            {
                this.students = value;
            }
        }

        public virtual ICollection<Material> Materials
        {
            get
            {
                return this.materials;
            }
            set
            {
                this.materials = value;
            }
        }
    }
}
