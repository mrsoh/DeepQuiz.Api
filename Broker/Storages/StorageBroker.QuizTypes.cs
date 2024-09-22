using Microsoft.EntityFrameworkCore;
using QuizAI.Api.Models.QuizTypes;

namespace QuizAI.Api.Broker.Storages
{
    public partial class StorageBroker
    {
        public DbSet<QuizType> QuizTypes { get; set; }

        private void CreateQuizTypeModel(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QuizType>()
                .HasKey(qt => qt.Id);
        }
    }
}
