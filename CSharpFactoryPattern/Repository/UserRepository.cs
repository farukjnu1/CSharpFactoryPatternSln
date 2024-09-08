using CSharpFactoryPattern.FactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFactoryPattern.Repository
{
    public class UserRepository: IRepository
    {
        private readonly Dictionary<int, User> _users = new Dictionary<int, User>();
        private int _currentId = 1;

        public void Create(IEntity entity)
        {
            var user = entity as User;
            user.Id = _currentId++;
            _users[user.Id] = user;
        }

        public IEntity Read(int id)
        {
            _users.TryGetValue(id, out var user);
            return user;
        }

        public void Update(IEntity entity)
        {
            var user = entity as User;
            _users[user.Id] = user;
        }

        public void Delete(int id)
        {
            _users.Remove(id);
        }
    }
}
