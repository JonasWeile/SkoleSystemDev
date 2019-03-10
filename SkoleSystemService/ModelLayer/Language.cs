using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ModelLayer {
    [DataContract]
    public class Language {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string LName { get; set; }

        public Language() {

        }

        public Language(string lName) {
            LName = lName;
        }
    }
}
