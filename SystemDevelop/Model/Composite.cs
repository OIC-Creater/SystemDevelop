using System;
using System.Security.Cryptography;
using System.Text;


namespace SystemDevelop.Model
{
    class Composite
    {
        private string Decrypt(string privateKey,string data)
        {
            //RSA暗号化サービスのインスタンスを準備
            RSACryptoServiceProvider csp = new RSACryptoServiceProvider();
            csp.FromXmlString(privateKey);

            //複合
            byte[] decryptedData = csp.Decrypt(Convert.FromBase64String(data), false);

            //UTF8に戻して返却
            return Encoding.UTF8.GetString(decryptedData);
        }
    }
}
