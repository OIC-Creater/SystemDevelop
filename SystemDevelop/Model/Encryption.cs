using System;
using System.Text;
using System.Security.Cryptography;

namespace SystemDevelop.Model
{
    class Encryption
    {
        public string Encrypt(string publicKey,string data)
        {
            // RSA暗号化サービスのインスタンスを準備
            RSACryptoServiceProvider csp = new RSACryptoServiceProvider();
            csp.FromXmlString(publicKey);

            //暗号化
            byte[] encryptedData = csp.Encrypt(Encoding.UTF8.GetBytes(data), false);
            
            //Base64エンコードした文字列を返却
            return Convert.ToBase64String(encryptedData);
        }  
            
    }
}
