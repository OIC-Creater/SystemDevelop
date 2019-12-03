using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SystemDevelop.Model
{
    class KeyContainer
    {
        private void CreateKey(string keyContainerName)
        {
            //新規鍵の設定
            int size = 1024;
            CspParameters parameters = new CspParameters()
            {
                KeyContainerName = keyContainerName
            };

            // 新規鍵の生成
            RSACryptoServiceProvider csp = new RSACryptoServiceProvider(size,parameters);
            //公開鍵をXMLで取得
            string publickey = csp.ToXmlString(false);
            //秘密鍵をXMLで取得
            string privateKey = csp.ToXmlString(true);

        }
        
    }
}
