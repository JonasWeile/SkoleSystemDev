using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ModelLayer {
    [DataContract]
    public class Person {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Ssn { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string PhoneNr { get; set; }
        [DataMember]
        public int Role_Id { get; set; }
        [DataMember]
        public int Department_Id { get; set; }

        public Person() {

        }

        public Person(string firstName, string lastName, string ssn, string email, string phoneNr, int role_Id, int department_Id) {
            FirstName = firstName;
            LastName = lastName;
            Ssn = ssn;
            Email = email;
            PhoneNr = phoneNr;
            Role_Id = role_Id;
            Department_Id = department_Id;
        }
    }
}
