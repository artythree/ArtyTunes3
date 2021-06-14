using ArtyTunes3.Controllers;
using ArtyTunes3.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArtyTunesTests
{
    [TestClass]
    public class UnitTest1
    {
        TrackForViewsController controller;
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        public void ParserTest()
        {
            CSVParser parser = new CSVParser();
            parser.Parser();
        }
        [TestMethod]
        public void PopularSongsTest()
        {
            controller.PopularSongs();
        }
        public void AverageDurationTest()
        {
            controller.AverageDuration();
        }
        [TestMethod]
        public void DetailsTest()
        {
            controller.Details("");

        }
    }
}
