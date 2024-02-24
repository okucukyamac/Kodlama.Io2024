using Intro.DataAccess.Abstracts;
using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.DataAccess.Concretes;

public class DapperCourseDal : ICourseDal
{
    List<Course> courses;

    public DapperCourseDal()
    {
        Course course1 = new Course
        {
            Id = 1,
            Name = "Rust",
            Description = ".NET 8...",
            Price = 0
        };
        Course course2 = new Course
        {
            Id = 2,
            Name = "JAVA",
            Description = "Java 17...",
            Price = 10
        };
        Course course3 = new Course
        {
            Id = 3,
            Name = "Python",
            Description = "Python 3.12...",
            Price = 20
        };

        courses = new List<Course> { course1, course2, course3 };
    }
    
    public List<Course> GetAll()
    {
        //burada db işlemleri yapılır.

        return courses;
    }

    public void Add(Course course)
    {
        courses.Add(course);
    }

}
