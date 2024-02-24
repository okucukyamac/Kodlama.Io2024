﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class CategoryManager : ICategoryService
{
    ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }

    public void Add(Category t)
    {
        _categoryDal.Add(t);
    }

    public void Delete(Category t)
    {
        _categoryDal.Delete(t);
    }

    public List<Category> GetAll()
    {
        return _categoryDal.GetAll();
    }

    public void Update(Category t)
    {
        _categoryDal.Update(t);
    }
}
