namespace MusicCompany.Services.Data.Tests
{
    using System.Linq;
    using MusicCompany.Data;
    using System.Collections.Generic;
    using System;
    // Fake Repository for the unit tests.
    public class InMemoryRepository<T> : IRepository<T>
        where T : class
    {
        private IList<T> data;

        public InMemoryRepository()
        {
            this.data = new List<T>();
            this.AttachedEntities = new List<T>();
            this.DetachedEntities = new List<T>();
        }

        public IList<T> AttachedEntities { get; private set; }

        public IList<T> DetachedEntities { get; private set; }

        public bool IsDisposed { get; private set; }

        public int CountSaveChanges { get; private set; }

        public IList<T> UpdatedEntities { get; private set; }

        public void Add(T entity)
        {
            this.data.Add(entity);
        }

        public IQueryable<T> All()
        {
            return this.data.AsQueryable();
        }

        public T Attach(T entity)
        {
            this.AttachedEntities.Add(entity);
            return entity;
        }

        public void Delete(object id)
        {
            if (this.data.Count == 0)
            {
                throw new InvalidOperationException("There is no data to delete!");
            }

            this.data.Remove(this.data[0]);
        }

        public void Delete(T entity)
        {
            if (!this.data.Contains(entity))
            {
                throw new InvalidOperationException("Entity not found!");
            }

            this.data.Remove(entity);
        }

        public void Detach(T entity)
        {
            this.DetachedEntities.Add(entity);
        }

        public void Dispose()
        {
            this.IsDisposed = true;
        }

        public T GetById(object id)
        {
            if (this.data.Count == 0)
            {
                throw new InvalidOperationException("There is no data!");
            }

            return this.data[0];
        }

        public int SaveChanges()
        {
            this.CountSaveChanges++;
            return this.CountSaveChanges;
        }

        public void Update(T entity)
        {
            this.UpdatedEntities.Add(entity);
        }
    }
}
