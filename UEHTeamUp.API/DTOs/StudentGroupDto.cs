namespace UEHTeamUp.API.DTOs
{
    public class StudentGroupDto
    {
        public string StudentEmail { get; set; } = string.Empty; // Email UEH (VD: student@st.ueh.edu.vn)
        public string CourseName { get; set; } = string.Empty;   // Tên môn học
        public string ClassCode { get; set; } = string.Empty;    // Mã lớp học phần (VD: BIT01_K49)
        public string GroupName { get; set; } = string.Empty;    // Tên nhóm (VD: Nhóm 1)
    }
}

