using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SkoleSystemService {
    
    [ServiceContract]
    public interface ISkoleSystemService {

        //Course
        [OperationContract]
        List<Course> GetAllCourseByGradeId(int grade_Id);
        [OperationContract]
        void CreateCourse(string cName);
        [OperationContract]
        void UpdateCourse(int id, string cName);
        [OperationContract]
        void DeleteCourse(int id);

        //Department
        [OperationContract]
        List<Department> GetAllDepartments();
        [OperationContract]
        void CreateDepartment(string dName, string address);
        [OperationContract]
        void UpdateDepartment(int id, string dName, string address);
        [OperationContract]
        void DeleteDepartment(int id);

        //Grade
        [OperationContract]
        List<Grade> GetAllGrades();
        [OperationContract]
        List<Grade> GetGradeById(int id);
        [OperationContract]
        void CreateGrade(string grName, int language_Id);
        [OperationContract]
        void UpdateGrade(int id, string grName, int language_Id);
        [OperationContract]
        void DeleteGrade(int id);

        //Group
        [OperationContract]
        List<Group> GetAllGroups();
        [OperationContract]
        List<Group> GetGroupById(int id);
        [OperationContract]
        void CreateGroup(string cName, DateTime startDate, DateTime endDate);
        [OperationContract]
        void UpdateGroup(int id, string cName);
        [OperationContract]
        void DeleteGroup(int id);

        //Language
        [OperationContract]
        List<Language> GetAllLanguages();
        [OperationContract]
        void CreateLanguage(string lName);
        [OperationContract]
        void UpdateLanguage(int id, string lName);
        [OperationContract]
        void DeleteLanguage(int id);

        //Person
        [OperationContract]
        List<Person> GetAllPersons();
        [OperationContract]
        List<Person> GetAllPersonsByGradeId(int grade_Id);
        [OperationContract]
        void CreatePerson(string firstName, string lastName, string ssn, string email, string phoneNr, int role_Id, int department_Id);
        [OperationContract]
        void UpdatePerson(int id, string firstName, string lastName, string ssn, string email, string phoneNr, int role_Id, int department_Id);
        [OperationContract]
        void DeletePerson(int id);

        //Role
        [OperationContract]
        List<Role> GetAllRoles();
        [OperationContract]
        void CreateRole(string rName);
        [OperationContract]
        void UpdateRole(int id, string rName);
        [OperationContract]
        void DeleteRole(int id);

    }
}
