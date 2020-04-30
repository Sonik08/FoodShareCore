using FoodShareCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShareCore.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
    }
}
