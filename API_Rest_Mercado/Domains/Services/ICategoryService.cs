using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Rest_Mercado.Communication;
using API_Rest_Mercado.Domains.Models;

namespace API_Rest_Mercado.Domains.Services
{
    public interface ICategoryService
    {
        public Task<IEnumerable<Category>> ListAsync();

        public Task<SaveCategoryResponse> SaveAsync(Category category);

        public Task<SaveCategoryResponse> UpdateAsync(int id, Category category);

        public Task<SaveCategoryResponse> DeleteAsync(int id);
    }
}
