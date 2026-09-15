using System.Net.Http.Json;
using UEHtheTeam.Models; // Model Course ở Frontend

namespace UEHtheTeam.Services // Sửa lại đúng Namespace của ứng dụng MAUI
{
    public class ApiService
    {
        private readonly HttpClient _httpClient = new();

        // BaseUrl trỏ đến Server API (IP 10.0.2.2 dành cho Android Emulator)
        private const string BaseUrl = "http://10.0.2.2:5106/api/";

        // 1. Lấy danh sách môn học từ CSDL SQL Server về Frontend
        public async Task<List<Course>> GetCoursesAsync()
        {
            try
            {
                var response = await _httpClient.GetFromJsonAsync<List<Course>>("courses");
                return response ?? new List<Course>();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Lỗi lấy danh sách môn học: {ex.Message}");
                return new List<Course>();
            }
        }

        // 2. Hàm đăng ký nhóm học tập (Đoạn code bạn vừa viết)
        public async Task<bool> SaveStudentGroupAsync(string email, string course, string classCode, string groupName)
        {
            try
            {
                var payload = new
                {
                    StudentEmail = email,
                    CourseName = course,
                    ClassCode = classCode,
                    GroupName = groupName
                };

                var response = await _httpClient.PostAsJsonAsync($"{BaseUrl}/groups/join-group", payload);
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Lỗi gọi API join-group: {ex.Message}");
                return false;
            }
        }
    }
}