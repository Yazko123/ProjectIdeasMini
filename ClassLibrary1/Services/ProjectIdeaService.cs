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

