using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShareCore.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        public ICategoryRepository Category { get; }
        void Save();
    }
}
