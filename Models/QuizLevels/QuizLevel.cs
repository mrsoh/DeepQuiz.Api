using QuizAI.Api.Models.Quizzes;

namespace QuizAI.Api.Models.QuizLevels
{
    public class QuizLevel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Quiz>? Quizzes { get; set; }
    }
}