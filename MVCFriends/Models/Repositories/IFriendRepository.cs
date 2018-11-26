using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCFriends.Models.Repositories
{
    public interface IFriendRepository
    {
        IEnumerable<Friend> SelectAll();
        Friend SelectByID(int id);
        void Insert(Friend obj);
        void Update(Friend obj);
        void Delete(int id);
        void Save();
    }
}
