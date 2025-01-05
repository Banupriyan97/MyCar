namespace MyCar.Server.Core
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
