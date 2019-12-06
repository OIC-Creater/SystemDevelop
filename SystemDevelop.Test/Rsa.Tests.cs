using NUnit.Framework;


namespace SystemDevelop.Model.Tests
{

    [TestFixture]
    class GenetationKeyTests
    {
        GenerationKey gk = new GenerationKey();

        [Test]
        public void RsaTest()
        {
            (string publicKey, string privateKey) = gk.CreateKey();
            Encryption enc = new Encryption();
            Composite com = new Composite();
            string a = enc.Encrypt(publicKey,"aaa");
            string b = com.Decrypt(privateKey,a);
            Assert.AreEqual("aaa", b);
        }
    }
}
