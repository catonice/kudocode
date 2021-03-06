﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using KudoCode.LogicLayer.Infrastructure.Domain.Interfaces;

namespace KudoCode.CodeGenerator.Repository
{
    public class ReadOnlyRepository : IReadOnlyRepository
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Sql(string sql, Action<DbDataReader> callBack)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll<TEntity>(
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = null,
            int? skip = null, int? take = null) where TEntity : class, IEntity
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> GetAllAsync<TEntity>(
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = null,
            int? skip = null, int? take = null) where TEntity : class, IEntity
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> Get<TEntity>(Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = null,
            int? skip = null, int? take = null) where TEntity : class, IEntity
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetIQueryable<TEntity>(Expression<Func<TEntity, bool>> filter = null,
            string includeProperties = null) where TEntity : class, IEntity
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> GetAsync<TEntity>(Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = null,
            int? skip = null,
            int? take = null) where TEntity : class, IEntity
        {
            throw new NotImplementedException();
        }

        public TEntity GetOne<TEntity>(Expression<Func<TEntity, bool>> filter = null, string includeProperties = null)
            where TEntity : class, IEntity
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetOneAsync<TEntity>(Expression<Func<TEntity, bool>> filter = null,
            string includeProperties = null) where TEntity : class, IEntity
        {
            throw new NotImplementedException();
        }

        public TEntity GetFirst<TEntity>(Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = null)
            where TEntity : class, IEntity
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetFirstAsync<TEntity>(Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = null)
            where TEntity : class, IEntity
        {
            throw new NotImplementedException();
        }

        public TEntity GetById<TEntity>(object id) where TEntity : class, IEntity
        {
            throw new NotImplementedException();
        }

        public ValueTask<TEntity> GetByIdAsync<TEntity>(object id) where TEntity : class, IEntity
        {
            throw new NotImplementedException();
        }

        public int GetCount<TEntity>(Expression<Func<TEntity, bool>> filter = null) where TEntity : class, IEntity
        {
            throw new NotImplementedException();
        }

        public Task<int> GetCountAsync<TEntity>(Expression<Func<TEntity, bool>> filter = null)
            where TEntity : class, IEntity
        {
            throw new NotImplementedException();
        }

        public bool GetExists<TEntity>(Expression<Func<TEntity, bool>> filter = null) where TEntity : class, IEntity
        {
            throw new NotImplementedException();
        }

        public Task<bool> GetExistsAsync<TEntity>(Expression<Func<TEntity, bool>> filter = null)
            where TEntity : class, IEntity
        {
            throw new NotImplementedException();
        }
    }
}