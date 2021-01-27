
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using EntityFramework.BulkExtensions;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Common.APAC.eSKU.Common.DAL.RepositoryContracts
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get(Int64 id);
        Task<TEntity> FindSingleAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includes);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, object>> orderByField, Int32 PageNumber = 1, Int32 NumberOfRecords = 50);
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, object>> orderByField, Int32 PageNumber = 1, Int32 NumberOfRecords = 50, params Expression<Func<TEntity, object>>[] includes);
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, object>> orderByField, Int32 PageNumber = 1, Int32 NumberOfRecords = 50);
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includes);

        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, object>> orderByField,
            Int32 PageNumber = 1, Int32 NumberOfRecords = 50, params Expression<Func<TEntity, object>>[] includes);

        // This method was not in the videos, but I thought it would be useful to add.
        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);

        // void BulkInsert(IEnumerable<TEntity> entities, InsertOptions InsertOptions = InsertOptions.Default);
       
        // void BulkInsertOrUpdate(IEnumerable<TEntity> entities, InsertOptions insertOptions = InsertOptions.Default);
        // void BulkDelete(IEnumerable<TEntity> entities);

        //Stored Procedures
        // 1. SqlQuery approach
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<IEnumerable<TEntity>> FindAllAsync(Expression<Func<TEntity, bool>> match);
        Task<IEnumerable<TEntity>> FindAllAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includes);
        IEnumerable<TEntity> ExcuteSqlQuery(string sqlQuery, CommandType commandType, SqlParameter[] parameters = null);
        // 2. SqlCommand approach
        void ExecuteNonQuery(string commandText, CommandType commandType, SqlParameter[] parameters = null);

        IEnumerable<TEntity> ExecuteReader(string commandText, CommandType commandType, SqlParameter[] parameters = null);
        void Update(TEntity entity);
    }
}
