using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ModelLayer {
    [DataContract]
    public class Role {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string RName { get; set; }

        public Role() {

        }

        public Role(string rName) {
            RName = rName;
        }
    }
}
