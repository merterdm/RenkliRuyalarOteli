﻿using RenkliRuyalarOteli.Entities.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RenkliRuyalarOteli.DAL.Abstract
{
    public interface IRepositoryBase<T> where T : BaseEntity, new()
    {
        Task<int> CreateAsync(T entity);
        Task<int> UpdateAsync(T entity);
        Task<int> DeleteAsync(T entity);
        Task<T> GetByIdAsync(string id);       
        Task<T> FindAsync(Expression<Func<T, bool>> filter = null);
        Task<IList<T>> FindAllAsync(Expression<Func<T, bool>> filter = null);
        Task<IQueryable<T>> FindAllIncludeAsync(Expression<Func<T, bool>> filter = null
            ,params Expression<Func<T, object>>[] include);
        Task<ICollection<T>> RawSqlQuery(T entity, string sql);
        
    }
}
