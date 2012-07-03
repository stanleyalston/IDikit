using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IDikit.Core.Model;

namespace IDikit.Tests.Model
{
    [TestClass]
    public class BookmarkTest
    {
        [TestMethod]
        public void CanGetBookmarkList()
        {

        }

        [TestMethod]
        public void CanSaveBookmark()
        {
            var bookmark = new Bookmark();
            bookmark.Save(new Bookmark 
                            { 
                                Title = "title",
                                Link = "http://www.google.com",
                                Description = "awetasdfasdf",
                                Member = 1,
                                Status = "Active"
                            });

            Assert.Inconclusive("Saved");
        }
    }
}
