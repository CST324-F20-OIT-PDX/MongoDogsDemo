using System.Collections.Generic;

using MongoDB.Bson;
using MongoDB.Driver;


public class MongoDogDB
{
    private IMongoDatabase db;

    private string _databaseName = "CST324";
    private string _collectionName = "Dogs";
    private readonly IMongoCollection<DogModel> _dogCollection;

    public MongoDogDB()
    {
        var client = new MongoClient();
        db = client.GetDatabase(_databaseName);
        _dogCollection = db.GetCollection<DogModel>(_collectionName);
    }

    public IList<DogModel> CallingAllDogs()
    {
           return _dogCollection.Find(new BsonDocument()).ToList();

    }

    public IList<DogModel> findABreed(string input_breed)
    {
        var filter = Builders<DogModel>.Filter.Eq("Breed1", input_breed);
        return _dogCollection.Find(filter).ToList();
    }



}
