﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SafeAssignmentSystem.Core.Data;
using System.Linq.Expressions;

namespace SafeAssignmentSystem.DataBase.Data.Common
{
	/// <summary>
	/// Implementation of repository access methods
	/// for Relational Database Engine
	/// </summary>
	/// <typeparam name="T">Type of the data table to which 
	/// current reposity is attached</typeparam>
	public class Repository : IRepository
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="context"></param>
		public Repository(SafeAssignmentDbContext context)
		{
			Context = context;
		}

		/// <summary>
		/// Entity framework DB context holding connection information and properties
		/// and tracking entity states 
		/// </summary>
		protected DbContext Context { get; set; }

		/// <summary>
		/// Representation of table in database
		/// </summary>
		protected DbSet<T> DbSet<T>() where T : class
		{
			return Context.Set<T>();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="procedureName"></param>
		/// <param name="args"></param>
		/// <returns></returns>
        public async Task<IEnumerable<T>> ExecuteProc<T>(string procedureName, params object[] args) where T : class
        {
            return await Context.Set<T>().FromSqlRaw($"/*NO LOAD BALANCE*/ select * from {procedureName}", args).ToListAsync();
        }

		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="query"></param>
		/// <param name="args"></param>
		/// <returns></returns>
        public async Task<IEnumerable<T>> ExecuteSQL<T>(string query, params object[] args) where T : class
        {
            return await Context.Set<T>().FromSqlRaw($"/*NO LOAD BALANCE*/ {query}", args).ToListAsync();
        }

        /// <summary>
        /// Adds entity to the database
        /// </summary>
        /// <param name="entity">Entity to add</param>
        public async Task AddAsync<T>(T entity) where T : class
		{
			await DbSet<T>().AddAsync(entity);
		}

		/// <summary>
		/// Ads collection of entities to the database
		/// </summary>
		/// <param name="entities">Enumerable list of entities</param>
		public async Task AddRangeAsync<T>(IEnumerable<T> entities) where T : class
		{
			await DbSet<T>().AddRangeAsync(entities);
		}

		/// <summary>
		/// All records in a table
		/// </summary>
		/// <returns>Queryable expression tree</returns>
		public IQueryable<T> All<T>() where T : class
		{
			return DbSet<T>().AsQueryable();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="search"></param>
		/// <returns></returns>
		public IQueryable<T> All<T>(Expression<Func<T, bool>> search) where T : class
		{
			return DbSet<T>().Where(search).AsQueryable();
		}

		/// <summary>
		/// The result collection won't be tracked by the context
		/// </summary>
		/// <returns>Expression tree</returns>
		public IQueryable<T> AllReadonly<T>() where T : class
		{
			return DbSet<T>()
				.AsQueryable()
				.AsNoTracking();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="search"></param>
		/// <returns></returns>
		public IQueryable<T> AllReadonly<T>(Expression<Func<T, bool>> search) where T : class
		{
			return DbSet<T>()
				.Where(search)
				.AsQueryable()
				.AsNoTracking();
		}

		/// <summary>
		/// Deletes a record from database
		/// </summary>
		/// <param name="id">Identificator of record to be deleted</param>
		public async Task DeleteAsync<T>(object id) where T : class
		{
			T entity = await GetByIdAsync<T>(id);

			Delete(entity);
		}

		/// <summary>
		/// Deletes a record from database
		/// </summary>
		/// <param name="entity">Entity representing record to be deleted</param>
		public void Delete<T>(T entity) where T : class
		{
			EntityEntry entry = Context.Entry(entity);

			if (entry.State == EntityState.Detached)
			{
				DbSet<T>().Attach(entity);
			}

			entry.State = EntityState.Deleted;
		}

		/// <summary>
		/// Detaches given entity from the context
		/// </summary>
		/// <param name="entity">Entity to be detached</param>
		public void Detach<T>(T entity) where T : class
		{
			EntityEntry entry = Context.Entry(entity);

			entry.State = EntityState.Detached;
		}

		/// <summary>
		/// Disposing the context when it is not neede
		/// Don't have to call this method explicitely
		/// Leave it to the IoC container
		/// </summary>
		public void Dispose()
		{
			Context.Dispose();
		}

		/// <summary>
		/// Gets specific record from database by primary key
		/// </summary>
		/// <param name="id">record identificator</param>
		/// <returns>Single record</returns>
		public async Task<T> GetByIdAsync<T>(object id) where T : class
		{
			return await DbSet<T>().FindAsync(id);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="id"></param>
		/// <returns></returns>
		public async Task<T> GetByIdsAsync<T>(object[] id) where T : class
		{
			return await DbSet<T>().FindAsync(id);
		}

		/// <summary>
		/// Saves all made changes in trasaction
		/// </summary>
		/// <returns>Error code</returns>
		public async Task<int> SaveChangesAsync()
		{
			return await Context.SaveChangesAsync();
		}

		/// <summary>
		/// Updates a record in database
		/// </summary>
		/// <param name="entity">Entity for record to be updated</param>
		public void Update<T>(T entity) where T : class
		{
			DbSet<T>().Update(entity);
		}

		/// <summary>
		/// Updates set of records in the database
		/// </summary>
		/// <param name="entities">Enumerable collection of entities to be updated</param>
		public void UpdateRange<T>(IEnumerable<T> entities) where T : class
		{
			DbSet<T>().UpdateRange(entities);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="entities"></param>
		public void DeleteRange<T>(IEnumerable<T> entities) where T : class
		{
			DbSet<T>().RemoveRange(entities);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="deleteWhereClause"></param>
		public void DeleteRange<T>(Expression<Func<T, bool>> deleteWhereClause) where T : class
		{
			var entities = All(deleteWhereClause);
			DeleteRange(entities);
		}

		/// <summary>
		/// Truncate table
		/// </summary>
		/// <param name="table">Table name</param>
		public async Task Truncate(string table)
		{
			await Context.Database.ExecuteSqlRawAsync($"TRUNCATE TABLE {table} RESTART IDENTITY");
		}

		/// <summary>
		/// Undo changes
		/// </summary>
		public void ChangeTrackerClear()
		{
			Context.ChangeTracker.Clear();
		}
	}
}
