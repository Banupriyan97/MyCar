using MyCar.Server.Core;

namespace MyCar.Server.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyCarDbContext context;

        public UnitOfWork(MyCarDbContext context)
        {
            this.context = context;
        }

        public async Task CompleteAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
