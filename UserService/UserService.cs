using MongoDB.Driver;

using UserService.Models;

namespace UserService
{
    public class UserService
    {


        private readonly IMongoCollection<User> _users;
        public UserService(IUserDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _users = database.GetCollection<User>(settings.UsersCollectionName);

        }

        public List<User> Get()
        {
            List<User> users;
            users = _users.Find(emp => true).ToList();
            return users;
        }

        public User Get(string id) =>
            _users.Find<User>(emp => emp.Id == id).FirstOrDefault();

        public void Post(User user) =>
           _users.InsertOne(user);


        public void Edit(string id, User user) =>
           _users.ReplaceOne(n => n.Id.Equals(id), user, new UpdateOptions { IsUpsert = true });



        public void Delete(string id) =>
      _users.DeleteOne(user => user.Id == id);

    }
}

