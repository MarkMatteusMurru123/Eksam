namespace Domain.Abstractions
{
    public interface IRepository<T> : ICrudMethods<T>, IPaging, ISorting, IFiltering { }
}
