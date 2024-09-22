using Microsoft.EntityFrameworkCore;

namespace QuizAI.Api.Broker.Storages
{
    public partial class StorageBroker : DbContext, IStorageBroker
    {
        private readonly ILogger<StorageBroker> Logger;
        private readonly IConfiguration Configration;

        public StorageBroker(ILogger<StorageBroker> logger, IConfiguration configration)
        {
            Logger = logger;
            Configration = configration;
            this.Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            CreateQuizModel(modelBuilder);
            CreateQuizTypeModel(modelBuilder);
            CreateQuizLevelModel(modelBuilder);
            CreateResponseModel(modelBuilder);
        }
    }
}