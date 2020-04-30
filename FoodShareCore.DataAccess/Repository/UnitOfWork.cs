using FoodShareCore.DataAccess.Data;
using FoodShareCore.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShareCore.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public ICategoryRepository Category { get; private set; }
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Category = new CategoryRepository(_context);
        }

        public void Dispose()
        {
            Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
