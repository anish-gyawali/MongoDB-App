using System;

namespace MongoDB
{
    class Program
    {
        static void Main(string[] args)
        {
            MongoCRUD db = new MongoCRUD("AddressBook");
            //PersonModel person = new PersonModel 
            //{
            //    Firstname="Ansu",
            //    Lastname="Gyawali",
            //    PrimaryAddress=new AddressModel
            //    {
            //        StreetAddress="1206 hooks dr",
            //        City="Hammond",
            //        State="LA",
            //        ZipCode="70401",

            //    }

            //};

            //db.InsertRecord("Users",person);
            
            //var records = db.LoadRecords<PersonModel>("Users");
            //foreach(var rec in records)
            //{
            //    Console.WriteLine($"{rec.Id}:{rec.Firstname}{rec.Lastname}");
            //    if (rec.PrimaryAddress != null)
            //    {
            //        Console.WriteLine(rec.PrimaryAddress.City);
            //    }
            //    Console.WriteLine();
            //}
           var rec= db.LoadRecordById<PersonModel>("Users", new Guid("4992cd9a-5e5b-4401-b080-df7d0ad33511"));
            rec.DateOfBirth = new DateTime(1997, 10, 19, 0, 0, 0, DateTimeKind.Utc);
            db.UpsertRecord("Users", rec.Id, rec);
            db.DeleteRecord<PersonModel>("Users", rec.Id);
            Console.ReadLine();
        }

    }

}
