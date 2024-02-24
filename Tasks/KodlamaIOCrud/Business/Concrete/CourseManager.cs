using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class CourseManager : ICourseService
{
    ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public void Add(Course t)
    {
        _courseDal.Add(t);
    }

    public void Delete(Course t)
    {
        _courseDal.Delete(t);
    }

    public List<Course> GetAll()
    {
        return _courseDal.GetAll();
    }

    public void Update(Course t)
    {
        _courseDal.Update(t);
    }
}
