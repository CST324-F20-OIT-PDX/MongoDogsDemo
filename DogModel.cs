using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


    public class DogModel
    {
        [BsonId]
        public BsonObjectId _id { get; set; }

    //    [BsonElement("owner_id")] 
        public int OwnerID { get; set; }

        public string OwnersAge { get; set; }

        public string Breed1 { get; set; }

        public int? DogYearOfBirth { get; set; }
        public string DogGender { get; set; }

        public string DogColor { get; set; }

    }

