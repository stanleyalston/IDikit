using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IDikit.Core.Concrete;

namespace IDikit.Core.Model
{
    public class Member
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ContactNo { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Status { get; set; }

        protected IDataContext context;

        public Member()
        {
            context = new IDataContext();
        }

        public List<Member> GetList()
        {
            return context.Members.ToList();
        }

        public void Save(Member member)
        {
            using (var db = new IDataContext())
            {
                db.Members.Add(member);
                db.SaveChanges();
            }
        }
    }
}
