using Microsoft.EntityFrameworkCore;
using QuizAI.Api.Models.Quizzes;
using QuizAI.Api.Models.Responses;

namespace QuizAI.Api.Broker.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Response> Responses { get; set; }

        private void CreateResponseModel(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Response>()
                .HasKey(r => r.Id);

            modelBuilder.Entity<Response>()
                .HasOne<Quiz>()
                .WithMany(r => r.Responses)
                .HasForeignKey(r => r.QuizId);
        }
    }
}