using QuizAI.Api.Models.QuizLevels;
using QuizAI.Api.Models.QuizTypes;
using QuizAI.Api.Models.Responses;

namespace QuizAI.Api.Models.Quizzes
{
    public class Quiz
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public int LevelId { get; set; }
        public string Value { get; set; }
        public string? Description { get; set; }
        public ICollection<Response>? Responses { get; set; }
        public QuizType Type { get; set; }
        public QuizLevel Level { get; set; }
    }
}