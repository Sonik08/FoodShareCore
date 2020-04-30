using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShareCore.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T: class
    {
        T GetByID(int id);

        IEnumerable<T> GetAll();

        void Add(T entity);

        void Remove(int id);

        void Remove(T entity);
    }
}
