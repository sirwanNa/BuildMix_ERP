namespace Firm.Infrastructure.Data
{
    public class FirmDbSeed
    {
        private FirmDbContext _dbContext;

        public FirmDbSeed(FirmDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task SeedAsync()
        {

        }
    }
}
