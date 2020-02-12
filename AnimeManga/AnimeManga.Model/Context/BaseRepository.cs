using AnimeManga.Model.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimeManga.Model.Context
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        readonly AnimeMangaContext _context;
        public BaseRepository(AnimeMangaContext context)
        {
            _context = context;
        }
        public void Delete(object id)
        {
            T existing = _context.Set<T>().Find(id);
            _context.Set<T>().Remove(existing);
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();

        }

        public T GetById(object id)
        {
            return _context.Set<T>().Find(id);

        }

        public void Insert(T obj)
        {
            _context.Set<T>().Add(obj);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(T obj)
        {
            _context.Set<T>().Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;

        }
    }
}
