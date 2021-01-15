using System.Threading.Tasks;
using Data.Abstractions;
using Domain.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Infra
{
    public abstract class UniqueEntityRepository<TDomain, TData> : PaginatedRepository<TDomain, TData>
        where TData : UniqueEntityData, new()
        where TDomain : Entity<TData>, new()
    {
        protected UniqueEntityRepository(DbContext c, DbSet<TData> s) : base(c, s)
        {
        }

        protected override async Task<TData> GetData(string id)
        {
            return await dbSet.FirstOrDefaultAsync(m => m.Id == id);
        }

        protected override string GetId(TDomain entity) => entity?.Data?.Id;
    }
}