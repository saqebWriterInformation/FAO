using DLL.Repos;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace DLL
{

    public class GenericRepository<T> where T : class
    {
        public InvoiceProcessingEntities DbContext = new InvoiceProcessingEntities();
        private readonly DbSet<T> DbSet;

        public IQueryable GetWithoutTracking(object id)
        {
            return DbSet.AsNoTracking();
        }

        public IQueryable GetWithTracking(object id)
        {
            return DbSet;
        }

        public async Task<T> Add(T entity)
        {
            var insertedEntity = DbSet.Add(entity);
            await DbContext.SaveChangesAsync();
            return insertedEntity;
        }

        public async Task<T> Update(T entityToUpdate)
        {
            DbContext.Entry(entityToUpdate).State = EntityState.Modified;
            await DbContext.SaveChangesAsync();
            return entityToUpdate;
        }

        public async Task<T> Delete(T entityToDelete)
        {
            if (DbContext.Entry(entityToDelete).State == EntityState.Detached)
            {
                DbSet.Attach(entityToDelete);
            }

            DbSet.Remove(entityToDelete);
            await DbContext.SaveChangesAsync();

            return entityToDelete;
        }
    }

}
