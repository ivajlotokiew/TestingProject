namespace Cars.Data.Repositories
{
    using Interfaces;
    using System.Data.Entity;

    public class Repository<T> : IRepository<T> where T : class
    {
        private DbSet<T> set;

        public Repository(DbSet<T> entitySet)
        {
            this.set = entitySet;
        }

        public void Add(T entity)
        {
            this.set.Add(entity);
        }

        public void Remove(T entity)
        {
            this.set.Remove(entity);
        }
    }
}