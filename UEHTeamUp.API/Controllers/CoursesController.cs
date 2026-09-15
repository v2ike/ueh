using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UEHTeamUp.API.Data;
using UEHTeamUp.API.Entities;

namespace UEHTeamUp.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CoursesController : ControllerBase
{
    private readonly AppDbContext _context;

    public CoursesController(AppDbContext context)
    {
        _context = context;
    }

    // GET: api/courses
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Course>>> GetCourses()
    {
        return await _context.Courses.ToListAsync();
    }
}