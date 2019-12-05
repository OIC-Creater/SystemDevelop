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

        }
    }
}



    



    

