using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Repository
{
    public class CategoryRepository : ICarsCategory
    {
        private readonly AppDBContext _context;
        public CategoryRepository(AppDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> AllCategories => _context.Category;
    }
}
