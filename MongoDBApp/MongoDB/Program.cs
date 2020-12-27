using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;

namespace MongoDB
{
    class Program
    {
        static void Main(string[] args)
        {
            MongoCRUD db = new MongoCRUD("AddressBook");
            db.InsertRecord("Users", new PersonModel { Firstname = "Anish", Lastname = "Gyawali" });
            Console.ReadLine();
        }
    }
    public class PersonModel
    {
        [BsonId]  //_Id 
        public Guid Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
    public class MongoCRUD
    {
        private IMongoDatabase db;
        public MongoCRUD(string database)
        {
            var client = new MongoClient();
                db = client.GetDatabase(database);
        }
    
    public void InsertRecord<T>(string table, T record)
    {
        var collection = db.GetCollection<T>(table);
            collection.InsertOne(record);
    }
    }
}
