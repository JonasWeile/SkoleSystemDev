using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using SkoleSystemService.DataAccessLayer;

namespace SkoleSystemService.Controller {

    public class GroupController : ICRUD<Group> {

        private DbGroup _dbGroup;

        public void Create(Group group) {
            _dbGroup = new DbGroup();
        }

        public void Delete(int id) {
            throw new NotImplementedException();
        }

        public Group Get(int id) {
            throw new NotImplementedException();
        }

        public IEnumerable<Group> GetAll() {
            throw new NotImplementedException();
        }

        public void Update(Group entity) {
            throw new NotImplementedException();
        }
    }
}
