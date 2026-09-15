using System.Text.Json.Serialization;

namespace UEHtheTeam.Models;

public class Course
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("courseCode")]
    public string CourseCode { get; set; } = string.Empty;

    [JsonPropertyName("courseName")]
    public string CourseName { get; set; } = string.Empty;

    [JsonPropertyName("credits")]
    public string Credits { get; set; } = string.Empty;

    [JsonPropertyName("courseType")]
    public string CourseType { get; set; } = string.Empty;

    [JsonPropertyName("tagBgColor")]
    public string TagBgColor { get; set; } = "#E6F4EA";

    [JsonPropertyName("tagTextColor")]
    public string TagTextColor { get; set; } = "#137333";

    public bool IsSelected { get; set; } = false;
}