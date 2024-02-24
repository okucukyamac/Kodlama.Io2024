using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete;

public class EfCategoryDal : ICategoryDal
{
    List<Category> _category;

    public EfCategoryDal()
    {
        _category = new List<Category>()

    {
        new Category { Id = 1, Name = "Dil" },
        new Category { Id = 2, Name = "Yazılım" },
        new Category { Id = 3, Name = "Matematik" }
    };
    }

    public void Add(Category entity)
    {
        _category.Add(entity);
    }

    public void Delete(Category entity)
    {
        Category categoryToDelete = _category.SingleOrDefault(c => c.Id == entity.Id);
        _category.Remove(categoryToDelete);
    }

    public Category Get(int id)
    {
        return _category.SingleOrDefault(x => x.Id == id);
    }

    public List<Category> GetAll()
    {
        return _category.ToList();
    }

    public void Update(Category entity)
    {
        Category categoryToUpdate = _category.SingleOrDefault(c => c.Id == entity.Id);
        categoryToUpdate.Name = entity.Name;
    }
}
