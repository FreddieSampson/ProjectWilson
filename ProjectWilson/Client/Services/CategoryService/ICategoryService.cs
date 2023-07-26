using ProjectWilson.Shared;

namespace ProjectWilson.Client.Services.CategoryService
{
    interface ICategoryService
    {
        List<Category> Categories { get; set; }
        Task LoadCategories();
    }
}
