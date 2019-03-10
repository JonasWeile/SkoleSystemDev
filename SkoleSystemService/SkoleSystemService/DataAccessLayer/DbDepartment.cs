using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using ProductService.DataAccessLayer;

namespace SkoleSystemService.DataAccessLayer {
    public class DbDepartment : ICRUD<Department> {

        private string _connectionString;

        public DbDepartment() {
            _connectionString = DB.DbConnectionString;
        }

        public void Create(Department department) {
            try {
                using (SqlConnection connection = new SqlConnection(_connectionString)) {
                    connection.Open();

                    using (SqlCommand cmdCreateDepartment = connection.CreateCommand()) {
                        cmdCreateDepartment.CommandText = "INSERT INTO Department(dName, address) VALUES(@dName, @address)";
                        cmdCreateDepartment.Parameters.AddWithValue("dName", department.DName);
                        cmdCreateDepartment.Parameters.AddWithValue("address", department.Address);
                        cmdCreateDepartment.ExecuteNonQuery();
                    }
                }
            } catch (SqlException ex) {

                throw ex;
            }
        }

        public void Delete(int id) {
            throw new NotImplementedException();
        }

        public Department Get(int id) {
            throw new NotImplementedException();
        }

        public IEnumerable<Department> GetAll() {
            List<Department> departments = new List<Department>();
            Department tempD;

            using (SqlConnection connection = new SqlConnection(_connectionString)) {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand()) {
                    cmd.CommandText = "SELECT id, dname, address from Department";
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read()) {
                        tempD = new Department();
                        tempD.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                        tempD.DName = reader.GetString(reader.GetOrdinal("DName"));
                        tempD.Address = reader.GetString(reader.GetOrdinal("Address"));
                        departments.Add(tempD);
                    }
                }
            }
            return departments;
        }

        public void Update(Department entity) {
            throw new NotImplementedException();
        }
    }
}
