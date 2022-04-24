using System;
using System.Collections.Generic;
using RentalBooksApi.Models.Base;

namespace RentalBooksApi.Repository.Generic
{
    public class GenericRepository<T> : IRepository<T> where  T : BaseEntity
    {
        private readonly AppDbContext _context;

        private DbSet<T> _dataset;
        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _dataset = _context.Set<T>();
        }
        
        public T Create(T item)
        {
            try
            {
                _dataset.Add(item);
                _context.SaveChanges();
                return item;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public T FindById(long id)
        {
            return _dataset.SingleOrDefault(t => t.Id.Equals(id));
        }

        public List<T> FindAll()
        {
            return _dataset.ToList();
        }

        public T Update(T item)
        {
            if (!Exists(item.Id)) return null;

            var itemFind = _dataset.FirstOrDefault(t => t.Id.Equals(item.Id));

            if (itemFind != null)
            {
                try
                {
                    _context.Entry(itemFind).CurrentValues.SetValues(item);
                    _context.SaveChanges();
                    return item;
                }
                catch (Exception)
                {

                    throw new Exception("Não foi possível faz a atualização");
                }
            }
            
            return null;
        }

        public void Delete(long id)
        {
            var itemFind = _dataset.SingleOrDefault(i => i.Id.Equals(id));
            if (itemFind != null)
            {
                try
                {
                    _dataset.Remove(itemFind);
                    _context.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }

        public bool Exists(long id)
        {
            return _dataset.Any(i => i.Id.Equals(id));
        }
    }
}