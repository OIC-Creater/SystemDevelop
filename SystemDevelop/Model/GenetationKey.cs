using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using NUnit.Framework;

namespace SystemDevelop.Model
{
    class GenetationKey
    {
        string encrypted = "";
        string decrypted = "";

        private void CreateKey()
        {
            //新規鍵の設定
            int size = 1024;
            //新規鍵の生成
            RSACryptoServiceProvider csp = new RSACryptoServiceProvider(size);
            //公開鍵をXMLで取得
            string publickey = csp.ToXmlString(false);
            //秘密鍵をXMLで取得
            string privateKey = csp.ToXmlString(true);

            string plainText = "";

            

            Console.WriteLine("PlainText\n{0}\n", plainText);

            encrypted = Encrypt(plainText, publickey);

            Console.WriteLine("Encrypted\n{0}\n", encrypted);

            decrypted = Decrypt(encrypted, privateKey);

            Console.WriteLine("Decrypted\n{0}\n", decrypted);


        }
        public static string Encrypt(string text, string publickey)
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(publickey);

                byte[] data = Encoding.UTF8.GetBytes(text);

                data = rsa.Encrypt(data, false);

                return Convert.ToBase64String(data);
            }
        }
        public static string Decrypt(string cipher, string privatekey)
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(privatekey);

                byte[] data = Convert.FromBase64String(cipher);

                data = rsa.Decrypt(data, false);

                return Encoding.UTF8.GetString(data);
            }
        }

    }
    
        
    }



    



    

