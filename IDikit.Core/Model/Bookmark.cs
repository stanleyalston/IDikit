using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IDikit.Core.Concrete;
namespace IDikit.Core.Model
{
    public class Bookmark
    {
        public int ID { get; set; }
        public int Member { get; set; }
        public string Link { get; set; } 
        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }

        protected IDataContext context;

        public Bookmark()
        {
            context = new IDataContext();
        }

        public List<Bookmark> GetList()
        {
            return context.Bookmarks.ToList();
        }

        public void Save(Bookmark bookmark)
        {
            using (var db = new IDataContext())
            {
                db.Bookmarks.Add(bookmark);
                db.SaveChanges();
            }
        }
    }
}
