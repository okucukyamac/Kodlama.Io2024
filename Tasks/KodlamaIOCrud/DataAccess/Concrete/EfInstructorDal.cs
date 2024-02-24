using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete;

public class EfInstructorDal : IInstructorDal
{
    List<Instructor> _instructor;

    public EfInstructorDal()
    {
        _instructor = new List<Instructor>()
        {
            new Instructor { Id = 1, FirstName = "Oğuz", LastName = "Küçük" },
            new Instructor { Id = 2, FirstName = "Zeynep", LastName = "Başer" }
        };
    }

    public void Add(Instructor entity)
    {
        _instructor.Add(entity);
    }

    public void Delete(Instructor entity)
    {
        Instructor instructorToDelete = _instructor.SingleOrDefault(i => i.Id == entity.Id);
        _instructor.Remove(instructorToDelete);
    }

    public Instructor Get(int id)
    {
        return _instructor.SingleOrDefault(x => x.Id == id);
    }

    public List<Instructor> GetAll()
    {
        return _instructor.ToList();
    }

    public void Update(Instructor entity)
    {
        Instructor instructorToUpdate = _instructor.SingleOrDefault(i => i.Id == entity.Id);
        instructorToUpdate.FirstName = entity.FirstName;
        instructorToUpdate.LastName = entity.LastName;
    }
}