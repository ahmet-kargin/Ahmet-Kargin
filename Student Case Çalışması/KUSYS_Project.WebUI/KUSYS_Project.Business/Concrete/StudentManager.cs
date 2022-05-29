using KUSYS_Project.Business.Abstract;
using KUSYS_Project.Data.Abstract;
using KUSYS_Project.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSYS_Project.Business.Concrete
{
    public class StudentManager : IStudentService
    {
        private IStudentRepository _studentRepository;
        public StudentManager(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public void Create(Student entity)
        {
            _studentRepository.Create(entity);
        }

        public bool Create(Student entity, int[] courseIds)
        {
            throw new NotImplementedException();
        }

        public void Delete(Student entity)
        {
            _studentRepository.Delete(entity);
        }

        public List<Student> GetAll()
        {
            return _studentRepository.GetAll();
        }

        public void Update(Student entity)
        {
            _studentRepository.Update(entity);
        }

        public void Update(Student entity, int[] courseIds)
        {
            throw new NotImplementedException();
        }
    }
}
