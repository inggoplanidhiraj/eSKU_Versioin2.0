
using Common.APAC.eSKU.Common.DAL.RepositoryContracts;
using AutoMapper;
using AutoMapper.Data;
using Dapper;
using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Common.APAC.eSKU.Common.DAL.Repositories
{
   public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext Context;
        private DbSet<TEntity> _entities;

        public Repository(DbContext context)
        {
            Context = context;
            _entities = Context.Set<TEntity>();
        }
        public TEntity Get(Int64 id)
        {
            // Here we are working with a DbContext, not PlutoContext. So we don't have DbSets 
            // such as Courses or Authors, and we need to use the generic Set() method to access them.
            return _entities.Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            // Note that here I've repeated Context.Set<TEntity>() in every method and this is causing
            // too much noise. I could get a reference to the DbSet returned from this method in the 
            // constructor and store it in a private field like _entities. This way, the implementation
            // of our methods would be cleaner:
            // 
            // _entities.ToList();
            // _entities.Where();
            // _entities.SingleOrDefault();
            // 
            // I didn't change it because I wanted the code to look like the videos. But feel free to change
            // this on your own.
            return _entities;
        }
        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, object>> orderByField, Int32 PageNumber = 1, Int32 NumberOfRecords = 50)
        {
            // Note that here I've repeated Context.Set<TEntity>() in every method and this is causing
            // too much noise. I could get a reference to the DbSet returned from this method in the 
            // constructor and store it in a private field like _entities. This way, the implementation
            // of our methods would be cleaner:
            // 
            // _entities.ToList();
            // _entities.Where();
            // _entities.SingleOrDefault();
            // 
            // I didn't change it because I wanted the code to look like the videos. But feel free to change
            // this on your own.
            return _entities.OrderBy(orderByField).Skip((PageNumber - 1) * NumberOfRecords).Take(NumberOfRecords);
        }

        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, object>> orderByField, Int32 PageNumber = 1, Int32 NumberOfRecords = 50, params Expression<Func<TEntity, object>>[] includes)
        {
            var query = _entities.OrderBy(orderByField).Skip((PageNumber - 1) * NumberOfRecords).Take(NumberOfRecords);
            return includes.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _entities.Where(predicate);
        }
        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, object>> orderByField, Int32 PageNumber = 1, Int32 NumberOfRecords = 50)
        {
            var query = _entities.Where(predicate);
            query = Queryable.OrderBy((dynamic)query, (dynamic)RemoveConvert(orderByField));
            query = query.Skip((PageNumber - 1) * NumberOfRecords).Take(NumberOfRecords);
            return query;
        }
        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includes)
        {
            var query = _entities.Where(predicate);
            return includes.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
        }
        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, object>> orderByField,
            Int32 PageNumber = 1, Int32 NumberOfRecords = 50, params Expression<Func<TEntity, object>>[] includes)
        {
            var query = _entities.Where(predicate);
            query = Queryable.OrderBy((dynamic)query, (dynamic)RemoveConvert(orderByField));
            query = query.Skip((PageNumber - 1) * NumberOfRecords).Take(NumberOfRecords);
            return includes.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
        }
        public async Task<TEntity> FindSingleAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includes)
        {
            var query = _entities.Where(predicate);
            return await  includes.Aggregate(query, (current, includeProperty) => current.Include(includeProperty)).SingleAsync();
        }

        public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return _entities.SingleOrDefault(predicate);
        }

        public void Add(TEntity entity)
        {
            _entities.Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            _entities.AddRange(entities);
        }

        public void Remove(TEntity entity)
        {
            _entities.Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _entities.RemoveRange(entities);
        }

        //Sql Methods
        public IEnumerable<TEntity> ExcuteSqlQuery(string sqlQuery, CommandType commandType, SqlParameter[] parameters = null)
        {
            if (commandType == CommandType.Text)
            {
                return SqlQuery(sqlQuery, parameters);
            }
            else if (commandType == CommandType.StoredProcedure)
            {
                return StoredProcedure(sqlQuery, parameters);
            }

            return null;
        }

        public void ExecuteNonQuery(string commandText, CommandType commandType, SqlParameter[] parameters = null)
        {
            if (Context.Database.CanConnect())
            {
                Context.Database.OpenConnection();
            }

            var command = Context.Database.GetDbConnection().CreateCommand();
            command.CommandText = commandText;
            command.CommandType = commandType;

            if (parameters != null)
            {
                foreach (var parameter in parameters)
                {
                    command.Parameters.Add(parameter);
                }
            }

            command.ExecuteNonQuery();
        }

        //public static IEnumerable<TEntity> GetRecordes(IDataReader reader)
        //{
        //    return Mapper.Map<IDataReader, IEnumerable<TEntity>>(reader);
        //}

        public IEnumerable<TEntity> ExecuteReader(string commandText, CommandType commandType, SqlParameter[] parameters = null/*, bool doMapData = true*/)
        {
            if (Context.Database.GetDbConnection().State == ConnectionState.Closed)
            {
                Context.Database.GetDbConnection().Open();
            }

            var command = Context.Database.GetDbConnection().CreateCommand();
            command.CommandText = commandText;
            command.CommandType = commandType;

            if (parameters != null)
            {
                foreach (var parameter in parameters)
                {
                    command.Parameters.Add(parameter);
                }
            }


            using (var reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    if (true)
                    {
                        var configuration = new MapperConfiguration(cfg =>
                        {
                            //MapperRegistry.Mappers.Add(new AutoMapper.Data.DataReaderMapper { YieldReturnEnabled = true });
                            cfg.AddDataReaderMapping(true);
                            cfg.CreateMap<IDataReader, TEntity>();//.ForMember(dest=>dest.,act=>act.Ignore());
                                                                  //cfg.
                                                                  // Other config
                        });

                        //configuration.AddDataReaderMapping(true);

                        //var configuration = new MapperConfiguration(cfg => { 
                        //});
                        configuration.AssertConfigurationIsValid();
                        var views = new Mapper(configuration).Map<IDataReader, IEnumerable<TEntity>>(reader);
                        return views;

                        //var configuration = new MapperConfiguration(cfg =>
                        //{
                        //    cfg.CreateMap<IDataReader, TEntity>().ReverseMap();
                        //});
                        //var mapper = configuration.CreateMapper();
                        //configuration.AssertConfigurationIsValid();
                        //var views = mapper.Map<IDataReader, IEnumerable<TEntity>>(reader);
                        //return views;

                        //var mapper = DataReaderMap<()TEntity>.CreateMap();
                        //var reader = (new DataTable()).CreateDataReader(); //example
                        //var list = mapper.ProjectToEnumerable(reader).ToList();

                        //var mapper = new DataReaderMapper().DataReaderObjectMapper();
                        //return mapper.MapExpression(configuration, )


                        //AutoMapper.Mapper.CreateMap<IDataReader, TEntity>();
                        //return AutoMapper.Mapper.Map<IDataReader, List<TEntity>>(dr);
                    }
                    //else
                    //    return reader;
                }
                return null;
            }

        }

        private IEnumerable<TEntity> SqlQuery(string sqlQuery, SqlParameter[] parameters = null)
        {
            if (parameters != null && parameters.Any())
            {
                var parameterNames = new string[parameters.Length];
                for (int i = 0; i < parameters.Length; i++)
                {
                    parameterNames[i] = parameters[i].ParameterName;
                }

                var result = Context.Database.GetDbConnection().Query<TEntity>(string.Format("{0}", sqlQuery, string.Join(",", parameterNames), parameters));
                return result.ToList();
            }
            else
            {
                var result = Context.Database.GetDbConnection().Query<TEntity>(sqlQuery);
                return result.ToList();
            }
        }

        private IEnumerable<TEntity> StoredProcedure(string storedProcedureName, SqlParameter[] parameters = null)
        {
            if (parameters != null && parameters.Any())
            {
                var parameterNames = new string[parameters.Length];
                for (int i = 0; i < parameters.Length; i++)
                {
                    if (parameters[i].DbType == DbType.String || parameters[i].DbType == DbType.DateTime)
                        parameterNames[i] = parameters[i].ParameterName + "='" + parameters[i].Value + "' ";

                    else
                        parameterNames[i] = parameters[i].ParameterName + "=" + parameters[i].Value;
                }

                var result = Context.Database.GetDbConnection().Query<TEntity>(string.Format("EXEC {0} {1}", storedProcedureName, string.Join(",", parameterNames), parameters));
                return result.ToList();
            }
            else
            {
                var result = Context.Database.GetDbConnection().Query<TEntity>(string.Format("EXEC {0}", storedProcedureName));
                return result.ToList();
            }
        }


        //Bulk Extension Methods
        // public void BulkInsert(IEnumerable<TEntity> entities, InsertOptions InsertOptions = InsertOptions.Default)
        // {
        //     BulkExtensions.BulkInsert<TEntity>(Context, entities, InsertOptions);
        // }

        //public void BulkUpdate(IEnumerable<TEntity> entities, UpdateOptions UpdateOptions = UpdateOptions.Default)
        //{
        //    BulkExtensions.BulkUpdate<TEntity>(Context, entities, UpdateOptions);
        //}

        // public void BulkInsertOrUpdate(IEnumerable<TEntity> entities, InsertOptions InsertOptions = InsertOptions.Default)
        // {
        //     BulkExtensions.BulkInsertOrUpdate<TEntity>(Context, entities, InsertOptions);
        // }

        // public void BulkDelete(IEnumerable<TEntity> entities)
        // {
        //     BulkExtensions.BulkDelete<TEntity>(Context, entities);
        // }

        static LambdaExpression RemoveConvert(LambdaExpression source)
        {
            var body = source.Body;
            while (body.NodeType == ExpressionType.Convert)
                body = ((UnaryExpression)body).Operand;
            return Expression.Lambda(body, source.Parameters);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
           return await _entities.ToListAsync();
        }
        public async Task<IEnumerable<TEntity>> FindAllAsync(Expression<Func<TEntity, bool>> match)  
       {  
      return await _entities.Where(match).ToListAsync();  
       }  

          public async Task<IEnumerable<TEntity>> FindAllAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includes)
        {
            var query = _entities.Where(predicate);
            return  await includes.Aggregate(query, (current, includeProperty) => current.Include(includeProperty)).ToListAsync();
        }

         public void  Update(TEntity entity){

            Context.Entry(entity).State = EntityState.Modified;
            //  _entities.Attach(entity);
         }
    }


}
