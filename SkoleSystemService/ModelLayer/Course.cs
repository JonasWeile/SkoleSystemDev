using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ModelLayer {
    [DataContract]
    public class Course {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string CName { get; set; }

        public Course() {

        }

        public Course(string cName) {
            CName = cName;
        }

    }
}
