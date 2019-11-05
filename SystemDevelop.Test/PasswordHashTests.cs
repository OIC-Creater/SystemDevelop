using NUnit.Framework;

namespace SystemDevelop.Model.Tests
{
    [TestFixture]
    class PasswordHashTests
    {
        PasswordHash ph = new PasswordHash();

        [Test]
        public void HashTest()
        {
            PasswordHash ph2 = new PasswordHash();
            string a = ph.Hash("aaa");
            string b = ph2.Hash("aaa");
            Assert.AreEqual(a, b);
        }
    }
}
