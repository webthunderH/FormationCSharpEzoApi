namespace Repository
{
    public interface IUnitOfWork
    {
        void SaveChange();
        void SaveChangesAsync();
    }
}