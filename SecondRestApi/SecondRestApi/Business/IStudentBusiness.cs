﻿using SecondRestApi.Model;
using System.Collections.Generic;

namespace SecondRestApi.Business
{
    public interface IStudentBusiness
    {
        Student Create(Student student);
        //Person FindById(long id);
        List<Student> FindAll();
        void Delete(string name);
        Student Update(Student student);
    }
}
