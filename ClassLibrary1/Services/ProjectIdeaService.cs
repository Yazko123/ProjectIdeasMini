using System.ComponentModel.DataAnnotations;

namespace SchollLibraryMini.Web.Models;

public enum Difficulty
{
    Easy,
    Medium,
    Hard
}

public static class DifficultyExtensions
{
    public static string ToBg(this Difficulty d) => d switch
    {
        Difficulty.Easy => "Лесно",
        Difficulty.Medium => "Средно",
        Difficulty.Hard => "Трудно",
        _ => d.ToString()
    };
}

public class ProjectIdea
{
    public int Id { get; set; }

    [Display(Name = "Заглавие")]
    [Required(ErrorMessage = "Заглавието е задължително.")]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "Заглавието трябва да е между 3 и 100 символа.")]
    public string Title { get; set; } = string.Empty;

    [Display(Name = "Категория")]
    [Required(ErrorMessage = "Изберете категория.")]
    public string Category { get; set; } = string.Empty;

    [Display(Name = "Трудност")]
    public Difficulty Difficulty { get; set; }

    [Display(Name = "Приблизителен брой часове")]
    [Required(ErrorMessage = "Въведете брой часове.")]
    [Range(1, 1000, ErrorMessage = "Часовете трябва да са положително число (1–1000).")]
    public int? EstimatedHours { get; set; }

    [Display(Name = "Описание")]
    [Required(ErrorMessage = "Описанието е задължително.")]
    [StringLength(1000, ErrorMessage = "Максимум 1000 символа.")]
    public string Description { get; set; } = string.Empty;
}