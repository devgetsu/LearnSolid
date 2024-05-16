using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.DI.Fail
{
    public class UserManager
    {
        private readonly Database _database;

        public UserManager()
        {
            _database = new Database();
        }

        public void AddUser(string userData)
        {
            _database.SaveData(userData); 
        }
    }
}
