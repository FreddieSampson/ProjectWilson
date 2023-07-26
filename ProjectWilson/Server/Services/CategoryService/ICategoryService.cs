using Microsoft.AspNetCore.Mvc;
using ProjectWilson.Shared;

namespace ProjectWilson.Server.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<List<Category>> GetCategories();
        Task<Category> GetCategoryByUrl(string categoryUrl);
    }
}
