﻿using Diamond.DataAccess.Data;
using Diamond.DataAccess.DTO;
using Diamond.DataAccess.IRepositories;
using Diamond.DataAccess.Models;
using Diamond.DataAccess.PageList;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.DataAccess.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DiamondDbContext _db;
        public CategoryRepository(DiamondDbContext db)
        {
            _db = db;
        }

        public async Task CreateAsync(Category category)
        {
            _db.Categories.Add(category);
        }

        public async Task DeleteAsync(Category category)
        {

            _db.Remove(category);

        }

        public Category Findid(int id)
        {
            return _db.Categories.Find(id);
        }

        public IList<Category> GetAll()
        {
            return _db.Categories.ToList();
        }

        public PagedResult<Category> GetAll(int page, int pageSize)
        {
            var query = _db.Categories.AsQueryable();
            var totalItems = query.Count();
            var categories = query.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            return new PagedResult<Category>
            {
                Items = categories,
                TotalItems = totalItems,
                PageNumber = page,
                PageSize = pageSize
            };
        }

        public async Task SaveChangesAsync()
        {
            await _db.SaveChangesAsync();
        }
    }
}