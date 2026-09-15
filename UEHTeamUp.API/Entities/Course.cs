namespace UEHTeamUp.API.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseCode { get; set; } = string.Empty;
        public string CourseName { get; set; } = string.Empty;
        public string Credits { get; set; } = string.Empty;
        public string CourseType { get; set; } = string.Empty;
        public string TagBgColor { get; set; } = "#F0FDFA";
        public string TagTextColor { get; set; } = "#004D53";
        public bool IsSelected { get; set; } = false;


    }
}
