using Microsoft.EntityFrameworkCore;
using QuizAI.Api.Models.QuizLevels;

namespace QuizAI.Api.Broker.Storages
{
    public partial class StorageBroker
    {
        public DbSet<QuizLevel> QuizLevels { get; set; }

        private void CreateQuizLevelModel(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QuizLevel>()
                .HasKey(l => l.Id);
        }
    }
}
