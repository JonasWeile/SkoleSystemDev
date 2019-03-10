using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ModelLayer;
using SkoleSystemService.DataAccessLayer;

namespace SkoleSystemService.Controller {
    public class GradeController : ICRUD<Grade> {

        private DbGrade _dbGrade;

        public GradeController() {
            _dbGrade = new DbGrade();
        }

        public void Create(Grade grade) {
            _dbGrade.Create(grade);
        }

        public void Delete(int id) {
            throw new NotImplementedException();
        }

        public Grade Get(int id) {
            throw new NotImplementedException();
        }

        public IEnumerable<Grade> GetAll() {
            throw new NotImplementedException();
        }

        public void Update(Grade entity) {
            throw new NotImplementedException();
        }
    }
}
