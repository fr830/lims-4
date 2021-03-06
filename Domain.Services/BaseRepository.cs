﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Domain.Model.Entities;
using Domain.Services.Contexts;
namespace Domain.Services
{
    public class BaseRepository<T> : IRepository<T> where T: class
    {
        private readonly DbContext _context;
        private DbSet<T> _dbSet;
        public BaseRepository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();

        }


        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public T Get(long id)
        {
            //return _dbSet.FirstOrDefault(t => t.);
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.AsNoTracking().ToList();    
        }

        public IQueryable<T> TableNoTracking()
        {
            return _dbSet.AsQueryable().AsNoTracking();
        }

        public IQueryable<T> Table()
        {
            return _dbSet.AsQueryable();
        }
        public void Insert(T entity)
        {
            _dbSet.Add(entity);
          //  throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
            return;
            throw new NotImplementedException();
        }


    }


}
