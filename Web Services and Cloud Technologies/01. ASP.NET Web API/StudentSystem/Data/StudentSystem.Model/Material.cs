namespace StudentSystem.Model
{
    public class Material
    {
        public int Id { get; set; }

        public MaterialType Type { get; set; }

        public int LectureId { get; set; }

        public virtual Lecture Lecture { get; set; }
    }
}
