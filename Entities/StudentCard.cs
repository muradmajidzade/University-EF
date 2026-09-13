namespace University.Entities
{
    public class StudentCard
    {
        public int Id { get; set; }
        public string ?CardNumber { get; set; }
        public DateOnly IssueDate { get; set; }
        public int StudentId { get; set; }
        public Student ?Student { get; set; }
    }
}
