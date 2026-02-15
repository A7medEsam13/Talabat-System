using System;
using System.Collections.Generic;
using System.Text;

namespace Talabat_System.Infrastructure.RepositoriesInterfaces
{
    public interface IGenericRepository<T>  where T : class
    {
        public Task<T> GetByIdAsync(int id);
        public Task<IEnumerable<T>> GetAllAsync();
        public Task AddAsync(T entity);
        //public Task UpdateAsync(T entity);
        public Task DeleteAsync(T entity);
    }
}
