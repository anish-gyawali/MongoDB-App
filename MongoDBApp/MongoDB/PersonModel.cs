using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace MongoDB
{
    public class PersonModel
    {
        [BsonId]  //_Id 
        public Guid Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public AddressModel PrimaryAddress { get; set; }
        [BsonElement("dob")]
        public DateTime DateOfBirth { get; set; }
    }

}
