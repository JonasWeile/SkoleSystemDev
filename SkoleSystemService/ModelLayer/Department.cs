using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ModelLayer
{
    [DataContract]
    public class Department
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string DName { get; set; }
        [DataMember]
        public string Address { get; set; }

        public Department() {

        }

        public Department(string dName, string address) {
            DName = dName;
            Address = address;
        }

        public override string ToString() {
            return $"{Id}{DName} ({Address})";
        }
    }
}
