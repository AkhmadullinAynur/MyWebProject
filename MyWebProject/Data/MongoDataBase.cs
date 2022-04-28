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
        //private readonly List<ProjectItem> projectItems;

        //public MongoDataBase(List<ProjectItem> projectItems)
        //{
        //    this.projectItems = projectItems;
        //}
        //[BsonIgnoreIfDefault]
        //public ObjectId _id { get; set; }

        //public List<ProjectItem> projectItems { get; set; }
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
    }
}
