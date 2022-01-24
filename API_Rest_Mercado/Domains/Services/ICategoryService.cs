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
        Task<IEnumerable<Category>> ListAsync();

        Task<SaveCategoryResponse> SaveAsync(Category category);

        Task<SaveCategoryResponse> UpdateAsync(int id, Category category);

        Task<SaveCategoryResponse> DeleteAsync(int id);
    }
}
