using ISBNGenerator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ISBNGeneratorUnitTests
{
    [TestClass]
    public class IsbnBuilderTests
    {
        private IIsbnBuilder _builder;

        [TestInitialize]
        public void SetUp()
        {
            _builder = new IsbnBuilder();
        }

        [TestMethod]
        public void Test_978155192370()
        {
            string isbn = _builder.GenerateIsbn("155192370");
            Assert.AreEqual(isbn, "155192370X");
        }

        [TestMethod]
        public void Test_978140007917()
        {
            string isbn = _builder.GenerateIsbn("140007917");
            Assert.AreEqual(isbn, "1400079179");
        }

        [TestMethod]
        public void Test_978037541457()
        {
            string isbn = _builder.GenerateIsbn("037541457");
            Assert.AreEqual(isbn, "0375414576");
        }


        [TestMethod]
        public void Test_978037428158()
        {
            string isbn = _builder.GenerateIsbn("037428158");
            Assert.AreEqual(isbn, "0374281580");
        }
    }
}
