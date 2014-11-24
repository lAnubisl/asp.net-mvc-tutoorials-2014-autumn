using Database.Repository.MongoDomain;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Linq;

namespace Database.Repository
{
    public class MongoDAO
    {
        private readonly MongoDatabase database;
        private readonly MongoCollection<Post> posts;

        public MongoDAO()
        {
            var url = MongoUrl.Create(ConfigurationManager.ConnectionStrings["mongodb"].ConnectionString);
            var client = new MongoClient(url);
            var server = client.GetServer();
            database = server.GetDatabase(url.DatabaseName);
            posts = database.GetCollection<Post>("Posts");
        }

        public Post LoadPost(string title)
        {
            var result = new Collection<Post>();
            var query = Query<Post>.EQ(e => e.Title, title);
            return posts.Find(query).FirstOrDefault();
        }

        public void SavePost(Post post)
        {
            posts.Save(post);
        }
    }
}