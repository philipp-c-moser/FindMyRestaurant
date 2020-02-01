﻿using System.Data.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using FindMyRestaurant.Infrastructure.Data;
using FindMyRestaurant.Core.Repositories;

namespace FindMyRestaurant.Infrastructure.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private AppDbContext _context;
        private DbSet<TEntity> _set;


        public Repository(AppDbContext context)
        {
            _context = context;
        }

        protected DbSet<TEntity> Set
        {
            get
            {
                return _set ?? (_set = _context.Set<TEntity>());
            }
        }





        public List<TEntity> GetAll()
        {
            return Set.ToList();
        }

        public Task<List<TEntity>> GetAllAsync()
        {
            return Set.ToListAsync();
        }


        public int Count()
        {
            return Set.Count();
        }

        public async Task<int> CountAsync()
        {
            return await Set.CountAsync();
        }




        public TEntity FindById(object id)
        {
            return Set.Find(id);
        }

        public Task<TEntity> FindByIdAsync(object id)
        {
            return Set.FindAsync(id);
        }



        public void Add(TEntity entity)
        {
            Set.Add(entity);
        }

        public void Update(TEntity entity)
        {
            var entry = _context.Entry(entity);
            if (entry.State == EntityState.Detached)
            {
                Set.Attach(entity);
                entry = _context.Entry(entity);
            }

            entry.State = EntityState.Modified;
        }

        public void Remove(TEntity entity)
        {
            Set.Remove(entity);
        }

    }
}