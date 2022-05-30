using KURS.BUSSINESS.Abstract;
using KURS.DATA.Abstract;
using KURS.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURS.BUSSINESS.Concrete
{
    public class CourseManager : ICourseService
    {
        private ICourseRepository _courseRepository;
        public CourseManager(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public void Create(Course entity)
        {
            _courseRepository.Create(entity);
        }

        public void Delete(Course entity)
        {
            _courseRepository.Delete(entity);
        }

        public List<Course> GetAll()
        {
            return _courseRepository.GetAll();
        }

        public Course GetById(int id)
        {
            return _courseRepository.GetById(id);
        }

        public void Update(Course entity)
        {
            _courseRepository.Update(entity);
        }
    }
}
