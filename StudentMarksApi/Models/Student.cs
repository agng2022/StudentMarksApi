namespace StudentMarksApi.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Dictionary<string, int> SubjectMarks { get; set; } = new();
    }
}
