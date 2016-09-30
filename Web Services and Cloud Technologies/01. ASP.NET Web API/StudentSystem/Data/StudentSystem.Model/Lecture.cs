namespace StudentSystem.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Lecture
    {
        private ICollection<Material> materials;

        public Lecture()
        {
            this.materials = new HashSet<Material>();
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int CourseId { get; set; }

        public virtual Course Course { get; set; }

        public virtual ICollection<Material> Materials
        {
            get { return this.materials; }
            set { this.materials = value; }
        }
    }
}
