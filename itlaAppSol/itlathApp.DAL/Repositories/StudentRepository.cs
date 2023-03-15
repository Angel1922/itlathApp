using itlathApp.DAL.Entities;
using itlathApp.DAL.context;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System;

namespace itlathApp.DAL.Repositories
{
    public class StudentRepository : Interfaces.IStudentRepository
    {
        private ItlaContext itlaContext;
        private ILogger<StudentRepository> logger;

        public StudentRepository(ItlaContext itlaContext,ILogger<StudentRepository> logger)
        {
            this.itlaContext = itlaContext;
            this.logger = logger;
        }
        public bool Exists(string name)
        {
            return this.itlaContext.Students.Any(st => st.FirstName == name);
        }
        
        public List<Student> GetAll()
        {
            return this.itlaContext.Students.ToList();
        }

        public Student GetById(int studentId)
        {
            return itlaContext.Students.Finds(studentId);
        }

        public void Remove(Student student)
        {
            try
            {
                Student studentToRemove = this.GetById(student.Id);

                studentToRemove.Deleted = true;
                studentToRemove.DeletedDate = DateTime.Now;
                studentToRemove.UserDeleted = student.UserDeleted;

                this.itlaContext.Students.Update(studentToRemove);
                this.itlaContext.SaveChanges();
            }
            catch (Exception ex)
            {
                this.logger.LogError($"Error removiendo el estudiante", ex.ToString());
            }
        }

        public void save(Student student)
        {
            try
            {
                Student studentToAdd = new Student()
                {
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    CreationDate = DateTime.Now,
                    CreationUser = student.CreationUser,
                    EnrollmentDate = student.EnrollmentDate
                };

                this.itlaContext.Students.Add(studentToAdd); 
                this.itlaContext.SaveChanges();
            }
            catch (Exception ex)
            {
                this.logger.LogError($"Error removiendo el estudiante", ex.ToString());
            }
        }

        public void Update(Student student)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Student studentToUpdate = this.GetById(student.Id);
                {
                    studentToUpdate.FirstName = student.FirstName;
                    studentToUpdate.LastName = student.LastName;
                    studentToUpdate.CreationDate = DateTime.Now;
                    studentToUpdate.CreationUser = student.CreationUser;
                    studentToUpdate.EnrollmentDate = student.EnrollmentDate;
                };
            }
        }
    }
}
