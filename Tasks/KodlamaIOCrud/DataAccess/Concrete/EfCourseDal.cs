using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete;

public class EfCourseDal : ICourseDal
{
    List<Course> _course;

    public EfCourseDal()
    {
        _course = new List<Course>()
    {
        new Course { Id = 1, Name = "C# + Angular", Description = "Yazılım Geliştirici Yetiştirici Kampı (C# + Angular)", CategoryId = 1, InstructorId = 1 },
        new Course { Id = 2, Name = "Javascript", Description = "Yazılım Geliştirici Yetiştirici Kampı (Javascript)", CategoryId = 1, InstructorId = 1 },
        new Course { Id = 3, Name = "Java + React", Description = "Yazılım Geliştirici Yetiştirici Kampı (Java + React)", CategoryId = 1, InstructorId = 1 },
        new Course { Id = 4, Name = ".Net", Description = "Senior Yazılım Geliştirici Kampı (.Net)", CategoryId = 1, InstructorId = 1 }

    };
    }

    public void Add(Course entity)
    {
        _course.Add(entity);
    }

    public void Delete(Course entity)
    {
        Course productToDelete = _course.SingleOrDefault(c => c.Id == entity.Id);
        _course.Remove(productToDelete);
    }

    public Course Get(int id)
    {
        return _course.FirstOrDefault(x => x.Id == id);
    }

    public List<Course> GetAll()
    {
        return _course.ToList();
    }

    public void Update(Course entity)
    {
        Course courseToUpdate = _course.SingleOrDefault(c => c.Id == entity.Id);
        courseToUpdate.Name = entity.Name;
        courseToUpdate.Description = entity.Description;
        courseToUpdate.CategoryId = entity.CategoryId;
        courseToUpdate.InstructorId = entity.InstructorId;
    }
}
