using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using ProductService.DataAccessLayer;

namespace SkoleSystemService.DataAccessLayer {
    public class DbGroup : ICRUD<Group> {

        private string _connectionString;

        public DbGroup() {
            _connectionString = DB.DbConnectionString;
        }

        public void Create(Group group) {
            try {
                using (SqlConnection connection = new SqlConnection(_connectionString)) {
                    connection.Open();

                    using (SqlCommand cmdCreateGrade = connection.CreateCommand()) {
                        cmdCreateGrade.CommandText = "INSERT INTO _Group(gName, startDate, endDate) VALUES(@gName, @startDate, @endDate);";
                        cmdCreateGrade.Parameters.AddWithValue("gName", group.GName);
                        cmdCreateGrade.Parameters.AddWithValue("startDate", group.StartDate);
                        cmdCreateGrade.ExecuteNonQuery();
                    }
                }
            } catch (SqlException ex) {

                throw ex;
            }
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
