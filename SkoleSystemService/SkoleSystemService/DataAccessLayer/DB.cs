using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkoleSystemService.DataAccessLayer {
    public class DB {
        public static string DbConnectionString {
            get { return ConfigurationManager.ConnectionStrings["_connectionString"].ToString(); }
        }
    }
}
