using Microsoft.EntityFrameworkCore;
using QuizAI.Api.Models.QuizLevels;
using QuizAI.Api.Models.QuizTypes;
using QuizAI.Api.Models.Quizzes;
using QuizAI.Api.Models.Responses;

namespace QuizAI.Api.Broker.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Quiz> Quizzes { get; set; }

        private void CreateQuizModel(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Quiz>()
                .HasKey(q => q.Id);

            modelBuilder.Entity<Quiz>()
                .HasOne(q => q.Type)
                .WithMany(qt => qt.Quizzes)
                .HasForeignKey(q => q.TypeId);

            modelBuilder.Entity<Quiz>()
                .HasOne<QuizLevel>()
                .WithMany(ql => ql.Quizzes)
                .HasForeignKey(q => q.LevelId);
        }
    }
}