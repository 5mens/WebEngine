using EngineModel;
using EngineModels.Interfaces.Users;
using EngineModels.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineModels.Repository.Users
{
    public class UserRepository : IUser
    {
        private readonly ApplicationDbContext applicationDbContext;
        public UserRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public void AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public void GetUser(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetUsers(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
