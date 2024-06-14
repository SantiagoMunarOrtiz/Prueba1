using System;
using System.Runtime.Serialization;

namespace YourNamespace
{
    [DataContract]
    public class User
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string? UserName { get; set; }  

        [DataMember]
        public string? Password { get; set; }  

        [DataMember]
        public DateTime RequestDate { get; set; }
    }
}
