﻿using Intro.DataAccess.Abstracts;
using Intro.DataAccess.Concretes;
using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Intro.Business; 

public class CourseManager
{
    private readonly ICourseDal _courseDal;
    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }
    public List<Course> GetAll()
    {
        //busines rull
        // iş kurallarından sonra

        return _courseDal.GetAll();
        
    }
}
