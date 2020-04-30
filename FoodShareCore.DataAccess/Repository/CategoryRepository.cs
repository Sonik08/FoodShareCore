using FoodShareCore.DataAccess.Data;
using FoodShareCore.DataAccess.Repository.IRepository;
using FoodShareCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FoodShareCore.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public void Update(Category category)
        {
            if (category == null)
                throw new ArgumentNullException();

            var categoryToUpdate = _context.Categories.SingleOrDefault(c => c.ID == category.ID);
            if (categoryToUpdate == null)
                throw new ArgumentNullException();

            categoryToUpdate.Update(category);
        }
    }
}
