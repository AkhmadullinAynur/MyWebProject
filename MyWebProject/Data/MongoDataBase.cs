using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebProject.Data
{
    public class MongoDataBase
    {
        public MongoDataBase(List<User> user)
        {
            this.user = user;
        }
        [BsonIgnoreIfDefault]
        public ObjectId _id { get; set; }
        [BsonElement("ListOfTasks")]
        public List<User> user { get; set; }
        public static List<string> GetUnitList()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Blazor");
            var collection = database.GetCollection<User>("Users");
            var listUnitsFromDB = collection.Find(x => true).ToList();
            List<string> listToReturn = new List<string>();
            foreach (var item in listUnitsFromDB)
            {
                listToReturn.Add(item.Name);
            }
            return listToReturn;
        }
        public static void AddUser(string login, string surname, string email, string phone, string password) //Добавление в БД
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Blazor");
            var collection = database.GetCollection<User>("Users");
            collection.InsertOne(new User(login, surname, email, phone, password));
        }
        public static List<User> GetUser(string login, string password)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Blazor");
            if (database.ListCollectionNames().ToList().Exists(x => x == login))
            {
                if (string.IsNullOrEmpty(login))
                {
                    return null;
                }
                else
                {
                    var collection = database.GetCollection<MongoDataBase>(login);
                    List<User> list = new List<User>();
                    list.AddRange(collection.Find(x => true).FirstOrDefault().user);
                    return list;
                    //var collection = database.GetCollection<MongoDataBase>(login);
                    //List<User> list = new List<User>();
                    //list.AddRange(collection.Find(x => true).FirstOrDefault().user);
                    //return list;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
