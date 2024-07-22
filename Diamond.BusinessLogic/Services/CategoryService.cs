using Diamond.BusinessLogic.IServices;
using Diamond.DataAccess.DTO;
using Diamond.DataAccess.IRepositories;
using Diamond.DataAccess.Models;
using Diamond.DataAccess.PageList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.BusinessLogic.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;
        public CategoryService( ICategoryRepository categoryRepository) {
            _repository = categoryRepository; 
        }

        public async Task CreateAsync(Category category)
        {
             await _repository.CreateAsync(category);
        }

        public async Task DeleteAsync(Category category)
        {
            _repository.DeleteAsync(category);
        }

        public Category Findid(int id)
        {
           return  _repository.Findid(id); 
        }

        public IList<Category> GetAll()
        {
            return _repository.GetAll();
        }

        public PagedResult<Category> GetAllpage(int page, int pageSize, string searchTerm)
        {
            var page1 = _repository.GetAllpage(page, pageSize , searchTerm);
            return page1;
        }

        public async Task<int> GetCategoryCountAsync()
        {
           return await _repository.GetCategoryCountAsync();    
        }

        public async Task SaveChangesAsync()
        {
            await _repository.SaveChangesAsync();
        }
    }
}
