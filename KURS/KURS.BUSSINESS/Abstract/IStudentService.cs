﻿using KURS.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURS.BUSSINESS.Abstract
{
    public interface IStudentService
    {
        List<Student> GetAll();
        void Update(Student entity);
        void Delete(Student entity);
        bool Create(Student entity, int[] courseIds);
        void Update(Student entity, int[] courseIds);
        
    }
}
