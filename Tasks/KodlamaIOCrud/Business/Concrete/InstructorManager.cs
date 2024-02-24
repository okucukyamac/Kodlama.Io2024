using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class InstructorManager : IInstructorService
{
    IInstructorDal _instructorDal;
    public InstructorManager(IInstructorDal instructorDal)
    {
        _instructorDal = instructorDal;
    }

    public void Add(Instructor t)
    {
        _instructorDal.Add(t);
    }

    public void Delete(Instructor t)
    {
        _instructorDal.Delete(t);
    }

    public List<Instructor> GetAll()
    {
        return _instructorDal.GetAll();
    }

    public void Update(Instructor t)
    {
        _instructorDal.Update(t);
    }
}
