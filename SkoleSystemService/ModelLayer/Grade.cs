using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ModelLayer {
    [DataContract]
    public class Grade {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string GrName { get; set; }
        [DataMember]
        public int Language_Id { get; set; }

        public Grade() {

        }

        public Grade(string grName, int language_Id) {
            GrName = grName;
            Language_Id = language_Id;
        }
    }
}
