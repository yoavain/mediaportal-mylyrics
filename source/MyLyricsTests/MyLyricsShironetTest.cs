﻿using System.Diagnostics;
using System.Threading;
using LyricsEngine.LyricsSites;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyLyricsTests
{
    [TestClass]
    public class MyLyricsShironetTest
    {
        [TestMethod]
        public void TestShironet1()
        {
            var mashinaAtidMatok = new Shironet("משינה", "עתיד מתוק", new ManualResetEvent(false), 10000);
            var splitMam = mashinaAtidMatok.Lyric.Split(' ');
            Assert.AreEqual("כולם", splitMam[0]);
            Assert.AreEqual("טוב...", splitMam[splitMam.Length - 1]);
        }

        [TestMethod]
        public void TestShironet2()
        {
            var shabakSamehNofelVekam = new Shironet("שבק ס", "נופל וקם", new ManualResetEvent(false), 10000);
            var splitSsnv = shabakSamehNofelVekam.Lyric.Split(' ');
            Assert.AreEqual("הדרך", splitSsnv[0]);
            Assert.AreEqual("ומפותלת...", splitSsnv[splitSsnv.Length - 1]);
        }

        [TestMethod]
        public void TestShironet3()
        {
            var erikBermanJetLag = new Shironet("אריק ברמן", "ג'ט לג", new ManualResetEvent(false), 10000);
            var splitEbjl = erikBermanJetLag.Lyric.Split(' ');
            Assert.AreEqual("אל", splitEbjl[0]);
            Assert.AreEqual("לסדין.", splitEbjl[splitEbjl.Length - 1]);
        }

        [TestMethod]
        public void TestShironet4()
        {
            var efratGoshTamid = new Shironet("אפרת גוש", "תמיד כשאתה בא", new ManualResetEvent(false), 10000);
            var splitEbjl = efratGoshTamid.Lyric.Split(' ');
            Assert.AreEqual("תמיד", splitEbjl[0]);
            Assert.AreEqual("באמת", splitEbjl[splitEbjl.Length - 1]);
        }

        [TestMethod]
        public void TestLoadShironet()
        {
            for (var i = 0; i < 100; i++)
            {
                Debug.WriteLine(string.Format("Iteration {0}", i));
                var mashinaAtidMatok = new Shironet("משינה", "עתיד מתוק", new ManualResetEvent(false), 3000);
                var splitMam = mashinaAtidMatok.Lyric.Split(' ');
                Assert.AreEqual("כולם", splitMam[0]);
                Assert.AreEqual("טוב...", splitMam[splitMam.Length - 1]);
            }
        }

        [TestMethod]
        public void TestShironetNotFound()
        {
            var notFound = new Shironet("Foo", "Bar", new ManualResetEvent(false), 10000);
            var splitNf = notFound.Lyric.Split(' ');
            Assert.AreEqual("Not", splitNf[0]);
            Assert.AreEqual("found", splitNf[splitNf.Length - 1]);
        }
    }
}
