using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using ModelLayer;
using ProductService.DataAccessLayer;

namespace SkoleSystemService.DataAccessLayer {
    public class DbGrade : ICRUD<Grade> {

        private string _connectionString;

        public DbGrade() {
            _connectionString = DB.DbConnectionString;
        }

        public void Create(Grade grade) {
            try {
                using (SqlConnection connection = new SqlConnection(_connectionString)) {
                    connection.Open();

                    using (SqlCommand cmdCreateGrade = connection.CreateCommand()) {
                        cmdCreateGrade.CommandText = "INSERT INTO Grade(grName, language_Id) VALUES(@grName, @language_Id)";
                        cmdCreateGrade.Parameters.AddWithValue("grName", grade.GrName);
                        cmdCreateGrade.Parameters.AddWithValue("language_Id", grade.Language_Id);
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

        public Grade Get(int id) {
            throw new NotImplementedException();
        }

        public IEnumerable<Grade> GetAll() {
            throw new NotImplementedException();
        }

        public void Update(Grade grade) {
            throw new NotImplementedException();
        }
    }
}
