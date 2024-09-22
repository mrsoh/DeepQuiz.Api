using QuizAI.Api.Models.Quizzes;

namespace QuizAI.Api.Models.Responses
{
    public class Response
    {
        public int Id { get; set; }
        public int QuizId { get; set; }
        public string Value { get; set; } = String.Empty;
        public bool IsChosen { get; set; }
        public bool IsCorrect { get; set; }
        public Quiz Quiz { get; set; }
    }
}