using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShareCore.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string  Name { get; set; }
        public string IconUrl { get; set; }

        internal Category()
        { }

        public Category(string name, string iconURL)
        {
            Name = name;
            IconUrl = iconURL;
        }
        public void Update(Category category)
        {
            if(category.Name != null)
                Name = category.Name;

            if(category.IconUrl != null)
                IconUrl = category.IconUrl;
        }
    }
}
