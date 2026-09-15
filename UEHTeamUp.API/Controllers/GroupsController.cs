using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UEHTeamUp.API.DTOs;

namespace UEHTeamUp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupsController : ControllerBase
    {
        // Giả lập CSDL tạm thời trong bộ nhớ RAM
        private static readonly List<StudentGroupDto> _database = new();

        // 1. Endpoint Đăng ký Sinh viên vào Nhóm Lớp
        // URL: POST http://localhost:5000/api/groups/join-group
        [HttpPost("join-group")]
        public IActionResult JoinGroup([FromBody] StudentGroupDto request)
        {
            if (string.IsNullOrWhiteSpace(request.ClassCode) || string.IsNullOrWhiteSpace(request.GroupName))
            {
                return BadRequest(new { success = false, message = "Vui lòng nhập đầy đủ Mã lớp và Tên nhóm!" });
            }

            _database.Add(request);

            return Ok(new
            {
                success = true,
                message = $"Đã thêm thành công sinh viên {request.StudentEmail} vào {request.GroupName} - Lớp {request.ClassCode}"
            });
        }

        // 2. Endpoint Lấy danh sách tất cả nhóm/sinh viên theo Mã Lớp
        // URL: GET http://localhost:5000/api/groups/by-class/BIT01_K49
        [HttpGet("by-class/{classCode}")]
        public IActionResult GetGroupsByClass(string classCode)
        {
            var result = _database
                .Where(g => g.ClassCode.Equals(classCode, StringComparison.OrdinalIgnoreCase))
                .ToList();

            return Ok(result);
        }
    }
}
