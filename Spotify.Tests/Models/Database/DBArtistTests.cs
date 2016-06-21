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
    public class DBArtistTests
    {
        [TestMethod()]
        public void GetArtistbyIdTest()
        {
            DBArtist dbArtist = new DBArtist();
            int actual = dbArtist.GetArtistbyId(1).ID;
            int expect = 1;
            Assert.AreEqual(expect, actual);
        }

        [TestMethod()]
        public void GetAlbumsFromArtistTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetSongsFromArtistTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetArtistsFromSongTest()
        {
            Assert.Fail();
        }
    }
}