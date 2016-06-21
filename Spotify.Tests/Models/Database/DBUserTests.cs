using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spotify.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Models.Database.Tests
{
    [TestClass()]
    public class DBUserTests
    {
        [TestMethod()]
        public void GetUserByIdTest()
        {
            DBUser dbUser = new DBUser();
            int actual = dbUser.GetUserById(1).ID;
            int expect = 1;
            Assert.AreEqual(expect, actual);
        }

        [TestMethod()]
        public void GetFollowingArtistsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetFollowingUsersTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetFollowingPlaylistsTest()
        {
            Assert.Fail();
        }
    }
}