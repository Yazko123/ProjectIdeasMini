namespace SchollLibraryMini.Web.Models;

public class ProjectIdeasIndexViewModel
{
    public string? Search { get; set; }
    public string? Category { get; set; }
    public IReadOnlyList<string> Categories { get; set; } = new List<string>();
    public IReadOnlyList<ProjectIdea> Items { get; set; } = new List<ProjectIdea>();
}