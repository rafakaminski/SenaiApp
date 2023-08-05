﻿using Microsoft.EntityFrameworkCore.Update.Internal;
using SenaiApp.Domain.Entidade;
using SenaiApp.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenaiApp.Repository.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {

        private SenaiAppContext _context;

        public GenericRepository(SenaiAppContext context)
        {
            _context = context;
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public T Salvar(T entity)
        {
            if ((entity as BaseEntity).Id == 0)
                Add(entity);
            else
                Update(entity);

            _context.SaveChanges();
            return entity;
        }




        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);

        }


        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }

        public void Remover(long id)
        {
            var entidade = _context.Set<T>().First(c => c.Id == id);
            _context.Set<T>().Remove(entidade);
            _context.SaveChanges();
        }

    }
}