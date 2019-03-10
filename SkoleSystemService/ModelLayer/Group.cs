using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ModelLayer {
    [DataContract]
    public class Group {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string GName { get; set; }
        [DataMember]
        public DateTime StartDate { get; set; }
        [DataMember]
        public DateTime EndDate { get; set; }

        public Group() {

        }

        public Group(string gName, DateTime startDate, DateTime endDate) {
            GName = gName;
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}
