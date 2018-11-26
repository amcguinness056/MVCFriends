using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCFriends.Models.Repositories
{
    public class FriendRepository : IFriendRepository
    {
        private FriendsDBContext db = null;

        public FriendRepository()
        {
            this.db = new FriendsDBContext();
        }

        public FriendRepository(FriendsDBContext db)
        {
            this.db = db;
        }

        public IEnumerable<Friend> SelectAll()
        {
            return db.Friends.OrderBy(a => a.Surname).ToList();
        }

        public Friend SelectByID(int id)
        {
            return db.Friends.Find(id);
        }

        public void Insert(Friend obj)
        {
            db.Friends.Add(obj);
        }

        public void Update(Friend obj)
        {
            db.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Friend existing = db.Friends.Find(id);
            db.Friends.Remove(existing);
        }

        public void Save()
        {
            db.SaveChanges();
        }

    }
}