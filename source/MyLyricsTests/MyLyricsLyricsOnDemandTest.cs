﻿using System.Threading;
using LyricsEngine.LyricsSites;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyLyricsTests
{
  [TestClass]
  public class MyLyricsLyricsOnDemandTest
  {
    [TestMethod]
    public void TestLyricsOnDemand()
    {
      var vanHalenCantStopLovinYou = new LyricsOnDemand("Van Halen", "I Can't Stop Lovin' You", new ManualResetEvent(false), 10000);
      var splitVhcslu = vanHalenCantStopLovinYou.Lyric.Split(' ');
      Assert.AreEqual("There's", splitVhcslu[0]);
      Assert.AreEqual("YOU", splitVhcslu[splitVhcslu.Length - 1]);

      var ericClaptonIShotTheSheriff = new LyricsOnDemand("Eric Clapton", "I Shot the Sheriff", new ManualResetEvent(false), 10000);
      var splitEcists = ericClaptonIShotTheSheriff.Lyric.Split(' ');
      Assert.AreEqual("I", splitEcists[0]);
      Assert.AreEqual("no.", splitEcists[splitEcists.Length - 1]);

      var barryManilowIWriteTheSongs = new LyricsOnDemand("Barry Manilow", "I Write The Songs", new ManualResetEvent(false), 10000);
      var splitBmiwts = barryManilowIWriteTheSongs.Lyric.Split(' ');
      Assert.AreEqual("I've", splitBmiwts[0]);
      Assert.AreEqual("songs", splitBmiwts[splitBmiwts.Length - 1]);
    }

    [TestMethod]
    public void TestLyricsOnDemandNotFound()
    {
      var notFound = new LyricsOnDemand("Foo", "Bar", new ManualResetEvent(false), 10000);
      var splitNf = notFound.Lyric.Split(' ');
      Assert.AreEqual("Not", splitNf[0]);
      Assert.AreEqual("found", splitNf[splitNf.Length - 1]);
    }
  }
}