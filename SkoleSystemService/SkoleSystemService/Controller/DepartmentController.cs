using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using SkoleSystemService.DataAccessLayer;

namespace SkoleSystemService.Controller {
    public class DepartmentController : ICRUD<Department> {

        private DbDepartment _dbDepartment;

        public DepartmentController() {
            _dbDepartment = new DbDepartment();
        }

        public void Create(Department department) {
            _dbDepartment.Create(department);
        }

        public void Delete(int id) {
            throw new NotImplementedException();
        }

        public Department Get(int id) {
            throw new NotImplementedException();
        }

        public IEnumerable<Department> GetAll() {
            return _dbDepartment.GetAll();
        }

        public void Update(Department entity) {
            throw new NotImplementedException();
        }
    }
}
