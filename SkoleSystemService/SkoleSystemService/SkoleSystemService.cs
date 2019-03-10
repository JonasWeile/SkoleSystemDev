using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ModelLayer;
using SkoleSystemService.Controller;

namespace SkoleSystemService {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class SkoleSystemService : ISkoleSystemService {
        public void CreateCourse(string cName) {
            throw new NotImplementedException();
        }

        public void CreateDepartment(string dName, string address) {
            Department dep = new Department(dName, address);
            DepartmentController dc = new DepartmentController();
            dc.Create(dep);
        }

        public void CreateGrade(string grName, int language_Id) {
            Grade grade = new Grade(grName, language_Id);
            GradeController gc = new GradeController();
            gc.Create(grade);
        }

        public void CreateGroup(string gName, DateTime startDate, DateTime endDate) {
            Group group = new Group(gName, startDate, endDate);
            GroupController gc = new GroupController();
            gc.Create(group);
        }

        public void CreateLanguage(string lName) {
            throw new NotImplementedException();
        }

        public void CreatePerson(string firstName, string lastName, string ssn, string email, string phoneNr, int role_Id, int department_Id) {
            throw new NotImplementedException();
        }

        public void CreateRole(string rName) {
            throw new NotImplementedException();
        }

        public void DeleteCourse(int id) {
            throw new NotImplementedException();
        }

        public void DeleteDepartment(int id) {
            throw new NotImplementedException();
        }

        public void DeleteGrade(int id) {
            throw new NotImplementedException();
        }

        public void DeleteGroup(int id) {
            throw new NotImplementedException();
        }

        public void DeleteLanguage(int id) {
            throw new NotImplementedException();
        }

        public void DeletePerson(int id) {
            throw new NotImplementedException();
        }

        public void DeleteRole(int id) {
            throw new NotImplementedException();
        }

        public List<Course> GetAllCourseByGradeId(int grade_Id) {
            throw new NotImplementedException();
        }

        public List<Department> GetAllDepartments() {
            DepartmentController dc = new DepartmentController();
            List<Department> foundDepartments = (List<Department>)dc.GetAll();
            return foundDepartments;
        }

        public List<Grade> GetAllGrades() {
            throw new NotImplementedException();
        }

        public List<Group> GetAllGroups() {
            throw new NotImplementedException();
        }

        public List<Language> GetAllLanguages() {
            throw new NotImplementedException();
        }

        public List<Person> GetAllPersons() {
            throw new NotImplementedException();
        }

        public List<Person> GetAllPersonsByGradeId(int grade_Id) {
            throw new NotImplementedException();
        }

        public List<Role> GetAllRoles() {
            throw new NotImplementedException();
        }

        public List<Grade> GetGradeById(int id) {
            throw new NotImplementedException();
        }

        public List<Group> GetGroupById(int id) {
            throw new NotImplementedException();
        }

        public void UpdateCourse(int id, string cName) {
            throw new NotImplementedException();
        }

        public void UpdateDepartment(int id, string dName, string address) {
            throw new NotImplementedException();
        }

        public void UpdateGrade(int id, string grName, int language_Id) {
            throw new NotImplementedException();
        }

        public void UpdateGroup(int id, string cName) {
            throw new NotImplementedException();
        }

        public void UpdateLanguage(int id, string lName) {
            throw new NotImplementedException();
        }

        public void UpdatePerson(int id, string firstName, string lastName, string ssn, string email, string phoneNr, int role_Id, int department_Id) {
            throw new NotImplementedException();
        }

        public void UpdateRole(int id, string rName) {
            throw new NotImplementedException();
        }
    }
}
